package org.example.PageObjects;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class VideoPlayerPage extends PageObject {
    protected WebDriver driver;

    @FindBy(id="")
    private WebElement play;

    @FindBy(id="")
    private WebElement pause;

    @FindBy(id="")
    private WebElement mute;

    @FindBy(id="")
    private WebElement scrubber;

    @FindBy(id="")
    private WebElement like;

    @FindBy(id="")
    private WebElement watch_later;

    public VideoPlayerPage(WebDriver driver){
        super(driver);
    }

    public void play() {

    }

    public void pause() {

    }

    public void mute() {

    }

    public void moverScrubberForward(WebElement width) {

    }

    public void moverScrubberBackward(WebElement width) {

    }

}
