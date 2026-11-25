namespace initiere_windows_forms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormaPrincipala(new Student("Maria", "Popescu", "maria.popescu@mail.ro", "maria123", 17)));
        }
    }
}
