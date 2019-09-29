package org.example;

import org.junit.Test;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.openqa.selenium.firefox.FirefoxBinary;
import org.openqa.selenium.firefox.FirefoxOptions;

import org.openqa.selenium.By;
import org.openqa.selenium.WebElement;




/**
 * Tests for Youtube Player.
 */
public class Youtube
{
    @Test
    public void openYoutube() throws InterruptedException {
        FirefoxBinary firefoxBinary = new FirefoxBinary();

        System.setProperty("webdriver.gecko.driver", "/usr/bin/geckodriver");

        FirefoxOptions firefoxOptions = new FirefoxOptions();
        firefoxOptions.setBinary(firefoxBinary);


        FirefoxDriver driver = new FirefoxDriver(firefoxOptions);
        driver.get("https://youtube.com");


        WebElement video = driver.findElement(By.cssSelector("div > #contents #img"));
        video.click();

        Thread.sleep(5000);

        driver.close();
    }


}
