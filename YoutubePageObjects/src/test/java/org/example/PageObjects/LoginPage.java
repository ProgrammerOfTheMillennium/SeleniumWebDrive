package org.example.PageObjects;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class LoginPage extends PageObject {
    private WebDriver driver;

    @FindBy(id="")
    private WebElement email;

    @FindBy(id="")
    private WebElement password;

    @FindBy(id="")
    private WebElement button;

    public LoginPage(WebDriver driver) {
        this.driver = driver;

        driver.get("https://");
    }

    public void login() {
        email.sendKeys("mail@mail.ru");
        password.sendKeys("password");

        button.click();
    }

}
