namespace Contacts.Data
{
    public static class DataConstants
    {
        //User
        public const int MaxUserName = 20;
        public const int MinUserName = 5;

        public const int MinEmail = 10;
        public const int MaxEmail = 60;

        public const int MinPassword = 5;
        public const int MaxPassword = 20;

        //Contact
        public const int MaxFirstName = 50;
        public const int MinFirstName = 2;

        public const int MaxLastName = 50;
        public const int MinLastName = 5;

        public const int MinContactEmail = 10;
        public const int MaxContactEmail = 60;

        public const int MinPhoneNumber = 10;
        public const int MaxPhoneNumber = 13;

        public const string ContactWebsiteRegex = @"^((www\.[A-Za-z0-9-]+.bg)|)$";

    }
}


     