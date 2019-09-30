package org.example.PageObjects;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.ui.LoadableComponent;

public class LoginPage extends PageObject /* LoadableComponent<LoginPage> */ {
    private WebDriver driver;

    @FindBy(id="")
    private WebElement email;

    @FindBy(id="")
    private WebElement password;

    @FindBy(id="")
    private WebElement button;

    public LoginPage(WebDriver driver) {
        super(driver);

        driver.get("https://");
    }

    public void login() {
        email.sendKeys("mail@mail.ru");
        password.sendKeys("password");

        button.click();
    }

}
