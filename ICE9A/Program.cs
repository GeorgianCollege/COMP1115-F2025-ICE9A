namespace ICE9A
{
    public enum FormType
    {
        Splash,
        Start,
        Next,
        Final,
        About
    }

    internal static class Program
    {
        // Declaring Form Variables
        public static SplashForm SplashForm;
        public static SelectionForm SelectionForm;
        public static NextForm NextForm;
        public static FinalForm FinalForm;
        public static AboutForm AboutForm;

        // Declare List of Form type named Forms
        public static List<Form> Forms;

        // Declare and initialize a bool named IsExiting
        public static bool IsExiting = false;


        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Instantiate an object of type SelectionForm
            Application.Run(new SelectionForm());
        }
    }
}