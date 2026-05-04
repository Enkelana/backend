namespace Innovation4Albania.DashboardBackend.Api.Models;

public static class ApplicationRoles
{
    public const string Kryeminister = "kryeminister";
    public const string Minister = "minister";
    public const string DrejtorAgjencie = "drejtor_agjencie";
    public const string DrejtorInovacioniPublik = "drejtor_inovacioni_publik";
    public const string StafAgjencie = "staf_agjencie";
    public const string StafMinistrie = "staf_ministrie";

    public static readonly IReadOnlyList<string> All =
    [
        Kryeminister,
        Minister,
        DrejtorAgjencie,
        DrejtorInovacioniPublik,
        StafAgjencie,
        StafMinistrie
    ];

    public static bool RequiresMinistry(string role) => role == StafMinistrie;

    public static bool CanCreateProjects(string role) => role is DrejtorAgjencie or DrejtorInovacioniPublik;

    public static bool CanManagePortfolio(string role) => role is DrejtorAgjencie or DrejtorInovacioniPublik;

    public static bool CanSubmitUpdates(string role) => role is DrejtorAgjencie or DrejtorInovacioniPublik or StafAgjencie;

    public static bool CanProposeProjectChanges(string role) => role == StafAgjencie;

    public static string ToDisplayLabel(string role) => role switch
    {
        Kryeminister => "KryeministÃ«r",
        Minister => "MinistÃ«r",
        DrejtorAgjencie => "Drejtori i Inovacionit",
        DrejtorInovacioniPublik => "Drejtor i DrejtorisÃ« sÃ« Inovacionit Publik",
        StafAgjencie => "Ekspert Agjencie",
        StafMinistrie => "Staf Ministrie",
        _ => role
    };
}

public static class ProjectStatuses
{
    public const string Planning = "planning";
    public const string Active = "active";
    public const string AtRisk = "at_risk";
    public const string Blocked = "blocked";
    public const string Completed = "completed";
    public const string Cancelled = "cancelled";

    public static readonly IReadOnlyList<string> All =
    [
        Planning,
        Active,
        AtRisk,
        Blocked,
        Completed,
        Cancelled
    ];

    public static string ToLabel(string value) => value switch
    {
        Planning => "Planifikim",
        Active => "Aktive",
        AtRisk => "NÃ« risk",
        Blocked => "PauzÃ«",
        Completed => "PÃ«rfunduara",
        Cancelled => "TÃ« anuluara",
        _ => value
    };

    public static string ToColor(string value) => value switch
    {
        Planning => "hsl(var(--warning))",
        Active => "hsl(var(--destructive))",
        AtRisk => "hsl(var(--destructive))",
        Blocked => "hsl(var(--muted-foreground))",
        Completed => "hsl(var(--success))",
        Cancelled => "hsl(var(--muted))",
        _ => "hsl(var(--muted-foreground))"
    };
}

public static class RiskLevels
{
    public const string Low = "low";
    public const string Medium = "medium";
    public const string High = "high";
    public const string Critical = "critical";

    public static readonly IReadOnlyList<string> All =
    [
        Low,
        Medium,
        High,
        Critical
    ];

    public static string ToLabel(string risk) => risk switch
    {
        Low => "I ulÃ«t",
        Medium => "Mesatar",
        High => "I lartÃ«",
        Critical => "Kritik",
        _ => risk
    };
}

public static class PerformanceBuckets
{
    public const string Excellent = "excellent";
    public const string Good = "good";
    public const string NeedsAttention = "needs_attention";
    public const string Completed = "completed";

    public static string ToLabel(string bucket) => bucket switch
    {
        Excellent => "NÃ« nivelin e duhur",
        Good => "MirÃ«",
        NeedsAttention => "KÃ«rkon vÃ«mendje",
        Completed => "PÃ«rfunduara",
        _ => bucket
    };
}

public static class EventTypes
{
    public const string Kickoff = "kickoff";
    public const string Completion = "completion";

    public static string ToLabel(string value) => value switch
    {
        Kickoff => "Nisja e projektit",
        Completion => "Mbyllja e projektit",
        _ => value
    };
}

public static class ProjectPriorities
{
    public const string Critical = "critical";
    public const string High = "high";
    public const string Medium = "medium";
    public const string Low = "low";

    public static readonly IReadOnlyList<string> All =
    [
        Critical,
        High,
        Medium,
        Low
    ];

    public static string ToLabel(string value) => value switch
    {
        Critical => "Kritike",
        High => "E lartÃ«",
        Medium => "Mesatare",
        Low => "E ulÃ«t",
        _ => value
    };
}

public static class ProjectSectors
{
    public const string Digitalization = "digitalization";
    public const string Infrastructure = "infrastructure";
    public const string PublicServices = "public_services";
    public const string Governance = "governance";
    public const string Education = "education";
    public const string Health = "health";
    public const string Agriculture = "agriculture";
    public const string Environment = "environment";

    public static readonly IReadOnlyList<string> All =
    [
        Digitalization,
        Infrastructure,
        PublicServices,
        Governance,
        Education,
        Health,
        Agriculture,
        Environment
    ];

    public static string ToLabel(string value) => value switch
    {
        Digitalization => "Digjitalizim",
        Infrastructure => "InfrastrukturÃ«",
        PublicServices => "ShÃ«rbime publike",
        Governance => "Qeverisje",
        Education => "Arsim",
        Health => "ShÃ«ndetÃ«si",
        Agriculture => "BujqÃ«si",
        Environment => "Mjedis",
        _ => value
    };
}

public static class WorkgroupRoles
{
    public const string ProjectLead = "project_lead";
    public const string OkrOwner = "okr_owner";
    public const string BusinessAnalyst = "business_analyst";
    public const string LegalExpert = "legal_expert";
    public const string TechnicalCoordinator = "technical_coordinator";
    public const string DataSpecialist = "data_specialist";
    public const string MinistryRepresentative = "ministry_representative";
    public const string ProjectOfficer = "project_officer";

    public static readonly IReadOnlyList<string> All =
    [
        ProjectLead,
        OkrOwner,
        BusinessAnalyst,
        LegalExpert,
        TechnicalCoordinator,
        DataSpecialist,
        MinistryRepresentative,
        ProjectOfficer
    ];

    public static string ToLabel(string value) => value switch
    {
        ProjectLead => "Drejtues projekti",
        OkrOwner => "Pronar OKR",
        BusinessAnalyst => "Analist biznesi",
        LegalExpert => "Ekspert ligjor",
        TechnicalCoordinator => "Koordinator teknik",
        DataSpecialist => "Specialist tÃ« dhÃ«nash",
        MinistryRepresentative => "PÃ«rfaqÃ«sues ministrie",
        ProjectOfficer => "Oficer projekti",
        _ => value
    };
}

