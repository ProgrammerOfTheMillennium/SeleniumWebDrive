package org.example.PageObjects;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class LogoutPage extends PageObject {
    private WebDriver driver;

    @FindBy(id="")
    private WebElement button;

    public LogoutPage(WebDriver driver) {
        this.driver = driver;

        driver.get("https://");
    }

    public void logout() {

        button.click();
    }

}
