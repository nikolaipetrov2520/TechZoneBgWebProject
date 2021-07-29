﻿using System.Collections.Generic;

namespace TechZoneBgWebProject.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "TechZoneBgWebProject";

        public const string SystemEmail = "no-reply@techzone-bg.com";

        public class Admin
        {
            public const string AdministratorAreaName = "Administration";
            public const string AdministratorRoleName = "Administrator";
            public const string AdministratorUserName = "0878432079";
            public const string AdministratorEmail = "admin@techzone-bg.com";
            public const string AdministratorPassword = "admin123456";
            public const string AdministratorProfilePicture = "#icon-ava-a";
            public const string AdministratorPhoneNumber = "0878432079";
            public const string AdministratorFirstName = "Nikolay";
            public const string AdministratorLastName = "Petrov";
        }

        public class NewsSource
        {
            public const string HiComm = "hicomm.bg";
            public const string Itninews = "itninews.com";
            public const string Kaldata = "kaldata.com";
            public const string HiCommUrl = "https://hicomm.bg";
            public const string ItninewsUrl = "https://wwwitninews.com";
            public const string KaldataUrl = "https://www.kaldata.com";
        }

        public class News
        {
            public static string[] Title =
                {
                "Huawei Watch 3 Pro (ВИДЕО РЕВЮ)",
                "Gorilla Glass DX ще защитава най-напред телефоните на Samsung (ВИДЕО)",
                "Италианският антимонополен регулатор глоби Google със 102 млн. евро",
                "Австралия: Google е подвела потребители за събирането на данни",
                "Google намалява таксата за разработчици на приложения за Play Store",
                "Зареждането на електрическите коли струва много повече за едни, отколкото за други",
                "Печалбите на технологичните гиганти ще растат стремглаво и в бъдеще",
                "Някои американски щати забраниха продажбите на мощни геймърски компютри",
                };

            public static string[] ImageUrl =
                {
                "https://hicomm.bg/uploads/articles/202107/67419/mainimage-huawei-watch-3-pro-video-revyu.jpg",
                "https://hicomm.bg/uploads/articles/202107/67445/600-mainimage-gorilla-glass-dx-shche-zashchitava-nai-napred-telefoni-na-samsung-video.jpg",
                "https://live.staticflickr.com/65535/48077951218_1923e91499_z.jpg",
                "https://upload.wikimedia.org/wikipedia/commons/1/10/Melbourne_Federal_Court.JPG",
                "https://www.itninews.com/images/google-play_sshot.jpg",
                "https://i2.wp.com/www.kaldata.com/wp-content/uploads/2021/07/Screenshot-at-Jul-28-17-33-58.png",
                "https://i2.wp.com/www.kaldata.com/wp-content/uploads/2021/07/Screenshot-at-Jul-28-16-51-13.png",
                "https://i1.wp.com/www.kaldata.com/wp-content/uploads/2021/07/The-sale-of-gaming-computers-is-banned-in-several-US-states.jpg",
                };

            public static string[] OriginalUrl =
                {
                "https://hicomm.bg/video-revu/huawei-watch-3-pro-video-revyu.html",
                "https://hicomm.bg/kratki-novini/gorilla-glass-dx-shche-zashchitava-nai-napred-telefoni-na-samsung-video.html",
                "https://www.itninews.com/newsit.php?readmore=3854",
                "https://www.itninews.com/newsit.php?readmore=3851",
                "https://www.itninews.com/newsit.php?readmore=3850",
                "https://www.kaldata.com/it-%d0%bd%d0%be%d0%b2%d0%b8%d0%bd%d0%b8/%d0%b7%d0%b0%d1%80%d0%b5%d0%b6%d0%b4%d0%b0%d0%bd%d0%b5%d1%82%d0%be-%d0%bd%d0%b0-%d0%b5%d0%bb%d0%b5%d0%ba%d1%82%d1%80%d0%b8%d1%87%d0%b5%d1%81%d0%ba%d0%b8%d1%82%d0%b5-%d0%ba%d0%be%d0%bb%d0%b8-%d1%81-365606.html",
                "https://www.kaldata.com/it-%d0%bd%d0%be%d0%b2%d0%b8%d0%bd%d0%b8/%d0%bf%d0%b5%d1%87%d0%b0%d0%bb%d0%b1%d0%b8%d1%82%d0%b5-%d0%bd%d0%b0-%d1%82%d0%b5%d1%85%d0%bd%d0%be%d0%bb%d0%be%d0%b3%d0%b8%d1%87%d0%bd%d0%b8%d1%82%d0%b5-%d0%b3%d0%b8%d0%b3%d0%b0%d0%bd%d1%82%d0%b8-365599.html",
                "https://www.kaldata.com/it-%d0%bd%d0%be%d0%b2%d0%b8%d0%bd%d0%b8/%d0%bd%d1%8f%d0%ba%d0%be%d0%b8-%d0%b0%d0%bc%d0%b5%d1%80%d0%b8%d0%ba%d0%b0%d0%bd%d1%81%d0%ba%d0%b8-%d1%89%d0%b0%d1%82%d0%b8-%d0%b7%d0%b0%d0%b1%d1%80%d0%b0%d0%bd%d0%b8%d1%85%d0%b0-%d0%bf%d1%80%d0%be-365584.html",
                };
        }

        public const string TestUserUserName = "testuser";
        public const string TestUserEmail = "testuser@techzone-bg.com";
        public const string TestUserPassword = "user123456";
        public const string TestUserProfilePicture = "#icon-ava-t";

        public const string DateTimeFormat = "dd/MM/yy HH:mm";
        public const string DateTimeShortFormat = "dd/MM/yy";

        public const string IFrameTag = "iframe";
        public const string AllowedFileExtensions = "jpg,jpeg,png";

        public const string UserUsernameDisplayName = "Display name";
        public const string UserLoginRememberMeDisplayName = "Remember me";
        public const string UserCurrentPasswordDisplayName = "Current password";
        public const string UserNewPasswordDisplayName = "New password";
        public const string UserConfirmPasswordDisplayName = "Confirm password";
        public const string UserConfirmNewPasswordDisplayName = "Confirm new password";
        public const string UserNewEmailDisplayName = "New email";
        public const string UserBirthDateDisplayName = "Birthday";
        public const int UserUsernameMaxLength = 25;
        public const int UserUsernameMinLength = 4;
        public const int UserPasswordMaxLength = 100;
        public const int UserPasswordMinLength = 6;
        public const int UserBiographyMaxLength = 250;
        public const int UserMinAge = 18;

        public const int TagNameMaxLength = 20;
        public const int TagNameMinLength = 3;
        public const string TagsDisplayName = "Tags";

        public const int CategoryNameMaxLength = 50;
        public const int CategoryNameMinLength = 3;

        public const int MessageContentMaxLength = 300;

        public const int PostTitleMaxLength = 100;
        public const int PostTitleMinLength = 3;
        public const int PostDescriptionMaxLength = 30000;
        public const int PostReportDescriptionMaxLength = 30000;
        public const int PostReportDescriptionMinLength = 3;
        public const string PostTypeDisplayName = "Post Type";

        public const int ReplyDescriptionMaxLength = 30000;
        public const int ReplyReportDescriptionMaxLength = 30000;
        public const int ReplyReportDescriptionMinLength = 3;

        public const int ShortDescriptionAllowedLength = 44;
    }
}
