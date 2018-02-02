namespace FormTest1
{
    public static class PageFactory
    {
        private static HomePage homePage;

        public static HomePage HomePage
        {
            get
            {
                if (homePage == null)
                    homePage = new HomePage();

                return homePage;
            }
        }

        private static ResponsePage responsePage;

        public static ResponsePage ResponsePage
        {
            get
            {
                if (responsePage == null)
                    responsePage = new ResponsePage();

                return responsePage;
            }
        }
    }
}
