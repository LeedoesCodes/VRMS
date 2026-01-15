using VRMS.Database;
using VRMS.UI.Config.Support;

namespace VRMS.Helpers;

public static class SystemLogger
{
    public static void Log(
        string action,
        string entity,
        int? entityId,
        string description
    )
    {
        // ----------------------------
        // REQUIRE AUTH CONTEXT
        // ----------------------------
        var currentUser = Session.CurrentUser;
        if (currentUser == null)
            return; // silently skip if no session (startup, background ops)

        // ----------------------------
        // WRITE LOG ENTRY
        // ----------------------------
        DB.Execute(
            "CALL sp_system_activity_logs_create(" +
            "@p_action, " +
            "@p_entity, " +
            "@p_entity_id, " +
            "@p_description, " +
            "@p_performed_by_user_id" +
            ");",

            ("@p_action", action),
            ("@p_entity", entity),
            ("@p_entity_id", entityId),
            ("@p_description", description),
            ("@p_performed_by_user_id", currentUser.Id)
        );
    }
}