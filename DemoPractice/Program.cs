using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

//Lauching Chrome Browser

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();

          //Entering name, password and click on login
driver.FindElement(By.Id("UserName")).SendKeys("Hari");
Thread.Sleep(1000);

driver.FindElement(By.Id("Password")).SendKeys("123123");
Thread.Sleep(1000);

driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]")).Click();
Thread.Sleep(2000);


                 //Verify logged in or nor 

IWebElement verificationText = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (verificationText.Text == "Hello hari!")
{
    Console.WriteLine("TurnUp Potal Logged in Successfully");
}

else
{ 
    Console.WriteLine("User not able to login");
}

Thread.Sleep(1000);


                //click on administration and select time and materials

driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
Thread.Sleep(1000);


driver.FindElement(By.LinkText("Time & Materials")).Click();
Thread.Sleep(2000);
Console.WriteLine("User clicked on Time and Materials");


//click on "Create" and send datas and save it

driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a")).Click();
Thread.Sleep(1000);

IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
typeCode.Click();
Thread.Sleep(1000);

IWebElement dropdownbutton = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
dropdownbutton.Click();
Thread.Sleep(1000);

driver.FindElement(By.Id("Code")).SendKeys("12345");
Thread.Sleep(1000);

driver.FindElement(By.Id("Description")).SendKeys("Automation Demo");
Thread.Sleep(1000);

driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]")).SendKeys("20");
Thread.Sleep(1000);


driver.FindElement(By.Id("SaveButton")).Submit();
Thread.Sleep(1000);

Console.WriteLine("Time and Materials created and submitted");


                        // Logout


IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
helloHari.Click();
Thread.Sleep(2000);


IWebElement dropDownField = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/ul/li[2]/a"));
dropDownField.Click();
Console.WriteLine("Logged out Successfully");














