from selenium import webdriver
import time

from selenium.webdriver.common.by import By

try: 
    link = "http://suninjuly.github.io/registration2.html"
    browser = webdriver.Chrome()
    browser.get(link)

    first_name = browser.find_element(By.XPATH, "//input[@placeholder='Input your first name']")
    first_name.send_keys("Bulat")

    last_name = browser.find_element(By.XPATH, "//input[@placeholder='Input your last name']")
    last_name.send_keys("Latypov")

    email = browser.find_element(By.XPATH, "//input[@placeholder='Input your email']")
    email.send_keys("yandex@ya.ru")


    phone_number = browser.find_element(By.XPATH, "//input[@placeholder='Input your phone:']")
    phone_number.send_keys("8-888-888-88-88")

    address = browser.find_element(By.XPATH, "//input[@placeholder='Input your address:']")
    address.send_keys("8-888-888-88-88")

    button = browser.find_element_by_css_selector("button.btn")
    button.click()

    time.sleep(1)


    welcome_text_elt = browser.find_element_by_tag_name("h1")
    welcome_text = welcome_text_elt.text

    assert "Congratulations! You have successfully registered!" == welcome_text

finally:
    time.sleep(10)
    browser.quit()
