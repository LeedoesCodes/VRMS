using System;
using System.Collections.Generic;
using VRMS.Models.Damages;
using VRMS.Repositories.Damages;

namespace VRMS.Services.Damage;

public class DamageService
{
    private readonly DamageRepository _damageRepo;
    private readonly DamageReportRepository _reportRepo;

    public DamageService()
    {
        _damageRepo = new DamageRepository();
        _reportRepo = new DamageReportRepository();
    }

    // ----------------------------
    // DAMAGE CATALOG
    // ----------------------------

    public int CreateDamage(string description, decimal estimatedCost)
    {
        if (string.IsNullOrWhiteSpace(description))
            throw new InvalidOperationException("Damage description is required.");

        if (estimatedCost < 0)
            throw new InvalidOperationException("Estimated cost cannot be negative.");

        return _damageRepo.Create(description, estimatedCost);
    }

    public void UpdateDamage(int damageId, string description, decimal estimatedCost)
    {
        if (string.IsNullOrWhiteSpace(description))
            throw new InvalidOperationException("Damage description is required.");

        if (estimatedCost < 0)
            throw new InvalidOperationException("Estimated cost cannot be negative.");

        _damageRepo.GetById(damageId); // existence check
        _damageRepo.Update(damageId, description, estimatedCost);
    }

    public void DeleteDamage(int damageId)
    {
        _damageRepo.Delete(damageId);
    }

    public Models.Damages.Damage GetDamageById(int damageId)
    {
        return _damageRepo.GetById(damageId);
    }

    public List<Models.Damages.Damage> GetAllDamages()
    {
        return _damageRepo.GetAll();
    }

    // ----------------------------
    // DAMAGE REPORTS
    // ----------------------------

    public int CreateDamageReport(int vehicleInspectionId, int damageId)
    {
        _damageRepo.GetById(damageId); // ensure damage exists
        return _reportRepo.Create(vehicleInspectionId, damageId);
    }

    public void ApproveDamageReport(int damageReportId)
    {
        var report = _reportRepo.GetById(damageReportId);

        if (report.Approved)
            throw new InvalidOperationException("Damage report is already approved.");

        _reportRepo.Approve(damageReportId);
    }

    public DamageReport GetDamageReportById(int damageReportId)
    {
        return _reportRepo.GetById(damageReportId);
    }

    public List<DamageReport> GetDamageReportsByInspection(int vehicleInspectionId)
    {
        return _reportRepo.GetByInspection(vehicleInspectionId);
    }

    public void SetDamageReportPhoto(int damageReportId, string photoPath)
    {
        _reportRepo.SetPhoto(damageReportId, photoPath);
    }

    public void DeleteDamageReportPhoto(int damageReportId)
    {
        _reportRepo.ResetPhoto(damageReportId);
    }
}
