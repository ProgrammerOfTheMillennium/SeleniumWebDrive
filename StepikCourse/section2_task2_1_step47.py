from selenium import webdriver
from selenium.webdriver.common.by import By

import time
import math

def calc(x):
  return str(math.log(abs(12*math.sin(int(x)))))



try: 
    link = "http://suninjuly.github.io/get_attribute.html"
    browser = webdriver.Chrome()
    browser.get(link)


    image = browser.find_element(By.CSS_SELECTOR, "img")
    value = image.get_attribute("valuex")
    
    browser.find_element(By.ID, "answer").send_keys(calc(value))
    browser.find_element(By.ID, "robotCheckbox").click()
    browser.find_element(By.ID, "robotsRule").click()

    button = browser.find_element_by_css_selector("button[class=\"btn btn-default\"")
    button.click()


finally:
    time.sleep(10)
    browser.quit()
