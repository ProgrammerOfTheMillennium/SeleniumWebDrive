from selenium import webdriver
from selenium.webdriver.common.by import By

import time
import math

def calc(x):
  return str(math.log(abs(12*math.sin(int(x)))))



try: 
    link = "http://suninjuly.github.io/math.html"
    browser = webdriver.Chrome()
    browser.get(link)

    number = browser.find_element(By.CSS_SELECTOR, "span[id=input_value]").text

    browser.find_element(By.ID, "answer").send_keys(calc(number))
    browser.find_element(By.ID, "robotCheckbox").click()
    browser.find_element(By.ID, "robotsRule").click()

    button = browser.find_element_by_css_selector("button[class=\"btn btn-default\"")
    button.click()


finally:
    time.sleep(10)
    browser.quit()
