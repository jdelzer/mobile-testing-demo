using System;
using Xamarin.UITest;
using Xamarin.UITest.Configuration;

namespace NUnit.Tests1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            return StartApp(platform, AppDataMode.Clear);
        }

        public static IApp RestartApp(Platform platform)
        {
            return StartApp(platform, AppDataMode.DoNotClear);
        }

        private static IApp StartApp(Platform platform, AppDataMode dataMode)
        {
            if (platform == Platform.Android)
            {
                var app = ConfigureApp
                    .Android
                    .ApkFile(@"C:\Users\JDelzer\source\repos\mobile-testing-demo\TaskApp\TaskyAndroid\bin\Release\com.xamarin.samples.taskyandroid.apk")
                    .StartApp(dataMode);

                return app;
            }
            else if (platform == Platform.iOS)
            {
                IApp app = ConfigureApp
                    .iOS
                    .StartApp(dataMode);

                return app;
            }

            throw new NotImplementedException();
        }
    }
}