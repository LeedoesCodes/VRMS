using System.Collections.Generic;
using VRMS.Models.Customers;
using VRMS.Repositories.Customers;

namespace VRMS.Services.Customer;

public class EmergencyContactService
{
    private readonly EmergencyContactRepository _contactRepo;
    private readonly EmergencyContactPhoneNumberRepository _phoneRepo;

    public EmergencyContactService()
    {
        _contactRepo = new EmergencyContactRepository();
        _phoneRepo   = new EmergencyContactPhoneNumberRepository();
    }

    // ----------------------------
    // EMERGENCY CONTACTS
    // ----------------------------

    public int CreateEmergencyContact(
        int customerId,
        string firstName,
        string lastName,
        string relationship
    )
    {
        return _contactRepo.Create(
            customerId,
            firstName,
            lastName,
            relationship
        );
    }

    public void UpdateEmergencyContact(
        int emergencyContactId,
        string firstName,
        string lastName,
        string relationship
    )
    {
        _contactRepo.Update(
            emergencyContactId,
            firstName,
            lastName,
            relationship
        );
    }

    public void DeleteEmergencyContact(int emergencyContactId)
    {
        _contactRepo.Delete(emergencyContactId);
    }

    public List<EmergencyContact> GetEmergencyContactsByCustomerId(int customerId)
    {
        return _contactRepo.GetByCustomerId(customerId);
    }

    // ----------------------------
    // EMERGENCY CONTACT PHONE NUMBERS
    // ----------------------------

    public int AddEmergencyContactPhoneNumber(
        int emergencyContactId,
        string phoneNumber
    )
    {
        return _phoneRepo.Create(emergencyContactId, phoneNumber);
    }

    public void UpdateEmergencyContactPhoneNumber(
        int phoneNumberId,
        string phoneNumber
    )
    {
        _phoneRepo.Update(phoneNumberId, phoneNumber);
    }

    public void DeleteEmergencyContactPhoneNumber(int phoneNumberId)
    {
        _phoneRepo.Delete(phoneNumberId);
    }

    public List<string> GetEmergencyContactPhoneNumbers(int emergencyContactId)
    {
        return _phoneRepo.GetByEmergencyContactId(emergencyContactId);
    }
}
