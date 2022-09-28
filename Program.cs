using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TikiCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of Chrome driver
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.facebook.com/");
            System.Threading.Thread.Sleep(5000);
            var usernameTxt = browser.FindElement(By.XPath("//*[@id=\"email\"]"));  
            usernameTxt.SendKeys("diepthanhthanhlovea5@gmail.com");
            var passwordTxt = browser.FindElement(By.XPath("//*[@id=\"pass\"]"));
            passwordTxt.SendKeys("Tranthuy&195");
            var signinBtn = browser.FindElement(By.XPath("//*[@name = 'login']"));
            signinBtn.Click();

            System.Threading.Thread.Sleep(5000);

            List<string> images = new List<string>();
            images.Add("C:/Users/Thanh/OneDrive/Hình ảnh/Cuộn phim/1FAD0BE2-42BF-4228-BB8E-94A3E6D99249.jpg");
            images.Add("C:/Users/Thanh/OneDrive/Hình ảnh/Cuộn phim/80CF6FDF-FE77-45EB-86DC-F93FE1466D4B.jpg");
            string imagePaths = String.Join("\n", images);
            //WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            System.Threading.Thread.Sleep(50000);
            var inputFile = browser.FindElement(By.XPath("//input[@type = 'file'][@accept = 'image/*,image/heif,image/heic,video/*,video/mp4,video/x-m4v,video/x-matroska,.mkv']"));
            //var inputFile = wait.Until(e => e.FindElement(By.XPath("//input[@type = 'file']")));
            //wait.Until(e => e.FindElement(By.XPath("//a/h3")));
            System.Threading.Thread.Sleep(5000);
            inputFile.SendKeys(imagePaths);
            System.Threading.Thread.Sleep(50000);
            //var uploadElement = browser.FindElement(By.XPath("//input[@type=\"file\"]"));
            //uploadElement.SendKeys(imagePaths);
            var postTxt = browser.FindElement(By.XPath("//div[contains(@aria-label, \"bạn đang nghĩ gì\")]"));
            postTxt.SendKeys("Automation upload images tool by Thanh Thanh. Demo môn EC312.L21");
            System.Threading.Thread.Sleep(50000);
            var editBtn = browser.FindElement(By.XPath("//div[@aria-label=\"Chỉnh sửa tất cả\"]"));
            System.Threading.Thread.Sleep(18000);
            editBtn.Click();
            System.Threading.Thread.Sleep(10000);
            var captionTextboxs = browser.FindElements(By.XPath("//textarea"));         
            for (int iProduct = 0; iProduct < captionTextboxs.Count; iProduct++)
            {
                captionTextboxs[iProduct].SendKeys("Đây là ảnh số " + (iProduct + 1));
            }
            System.Threading.Thread.Sleep(5000);
            var submitBtn = browser.FindElement(By.XPath("//div[@aria-label=\"Xong\"]"));
            System.Threading.Thread.Sleep(18000);
            submitBtn.Click();
            System.Threading.Thread.Sleep(50000);
            var submitBTN = browser.FindElement(By.XPath("//div[@aria-label=\"Đăng\"]"));
            System.Threading.Thread.Sleep(18000);
            submitBTN.Click();

        }
    }
}
