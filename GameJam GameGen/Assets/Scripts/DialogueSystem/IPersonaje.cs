public interface IPersonaje
{
    bool PistolaInvestigada { get; set; }

    bool Identificacion { get; set; }
    bool wherePistola { get; set; }

    bool crucifijoInvestigado { get; set; }
    bool sogaInvestigada { get; set; }
    bool missingCuchillo { get; set; }

    bool moratonJuanInvestigado { get; set; }
    bool narizRotaPedroInvestigada { get; set; }
    bool nudillosMiguelAInvestigados { get; set; }
    bool heridaJoseManuel { get; set; }

    bool horaMimirEstandar { get; set; }
    bool horaMimirAna { get; set; }
    bool horaMimirJoseManuel { get; set; }

    bool anaTestigoJoseManuel { get; set; }
    bool anaTestigoMiguelA { get; set; }
    bool apareceJoseManuel { get; set; }
    bool joseCatalinaParranda { get; set; }
    bool pedroLlamo { get; set; }

    bool chusoSotano { get; set; }

    bool anaMiguel { get; set; }

    bool chaqueta { get; set; }

    public void Talk();

    public void Updated(string s);
}