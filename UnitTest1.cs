using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KayakCanoeTests
{
    public class KayakCanoeTests
    {
        private IWebDriver driver;

        // Индивидуальные ссылки для тестирования
        private string url1 = "https://kayak-canoe.ru/ru/";
        private string url2 = "https://kayak-canoe.ru/ru/novosti-i-sobytiya/novosti";
        private string url3 = "https://kayak-canoe.ru/ru/mul-timedia/foto";
        private string url4 = "https://kayak-canoe.ru/ru/nauka/organizatsii";
        private string url5 = "https://kayak-canoe.ru/ru/antidoping/vada-i-rusada";
        private string url6 = "https://kayak-canoe.ru/ru/sbornye-komandy/galereya-slavy";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void TestLinks()
        {
            var urls = new[] { url1, url2, url3, url4, url5 };

            foreach (var url in urls)
            {
                driver.Navigate().GoToUrl(url);

                Assert.That(driver.Title, Is.Not.Empty, $"Страница {url} не загрузилась.");
            }
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
