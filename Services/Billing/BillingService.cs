using VRMS.Enums;
using VRMS.Models.Billing;
using VRMS.Repositories.Billing;
using VRMS.Services.Rental;

namespace VRMS.Services.Billing;

public class BillingService
{
    private readonly RentalService _rentalService;
    private readonly InvoiceRepository _invoiceRepo;
    private readonly PaymentRepository _paymentRepo;

    public BillingService(
        RentalService rentalService,
        InvoiceRepository invoiceRepo,
        PaymentRepository paymentRepo)
    {
        _rentalService = rentalService;
        _invoiceRepo = invoiceRepo;
        _paymentRepo = paymentRepo;
    }

    // ---------------- INVOICES ----------------

    public int GenerateInvoiceForRental(
        int rentalId,
        decimal totalAmount)
    {
        var rental =
            _rentalService.GetRentalById(rentalId);

        if (rental.Status is not
            (RentalStatus.Completed or RentalStatus.Late))
            throw new InvalidOperationException(
                "Invoice can only be generated for completed or late rentals.");

        if (_invoiceRepo.GetByRental(rentalId) != null)
            throw new InvalidOperationException(
                "Invoice already exists for this rental.");

        return _invoiceRepo.Create(
            rentalId,
            totalAmount,
            DateTime.UtcNow);
    }

    public Invoice GetInvoiceById(int invoiceId)
        => _invoiceRepo.GetById(invoiceId);

    public Invoice? GetInvoiceByRental(int rentalId)
        => _invoiceRepo.GetByRental(rentalId);

    // ---------------- PAYMENTS ----------------

    public int AddPayment(
        int invoiceId,
        decimal amount,
        PaymentMethod method,
        DateTime date)
    {
        if (amount <= 0)
            throw new InvalidOperationException(
                "Payment amount must be greater than zero.");

        var balance = GetInvoiceBalance(invoiceId);
        if (amount > balance)
            throw new InvalidOperationException(
                "Payment exceeds outstanding balance.");

        return _paymentRepo.Create(
            invoiceId,
            amount,
            method,
            date);
    }

    public List<Payment> GetPaymentsByInvoice(int invoiceId)
        => _paymentRepo.GetByInvoice(invoiceId);

    // ---------------- BALANCE ----------------

    public decimal GetInvoiceBalance(int invoiceId)
    {
        var invoice = _invoiceRepo.GetById(invoiceId);
        var payments =
            _paymentRepo.GetByInvoice(invoiceId);

        decimal paid = 0m;
        foreach (var p in payments)
            paid += p.Amount;

        return invoice.TotalAmount - paid;
    }
}
