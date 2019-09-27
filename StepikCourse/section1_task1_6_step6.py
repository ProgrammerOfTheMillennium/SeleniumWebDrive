from selenium import webdriver
import time

link = "http://suninjuly.github.io/huge_form.html"

try:
    browser = webdriver.Chrome()
    browser.get(link)

    elements = browser.find_elements_by_tag_name("input")
    for element in elements:
        element.send_keys("My answer")
    

    first_name = browser.find_element_by_name("firstname")
    first_name.clear()
    first_name.send_keys("Bulat")

    last_name = browser.find_element_by_name("lastname")
    last_name.clear()    
    last_name.send_keys("Latypov")

    button = browser.find_element_by_css_selector("button.btn")
    button.click()

finally:
    time.sleep(30)
    browser.quit()

