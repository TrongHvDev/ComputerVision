import cv2 as cv
import numpy as np

img = cv.imread("Lenna.jpg", cv.IMREAD_COLOR)   

#BGR image

blue = img.copy()
# set green and red channel to 0
blue[:, :, 1] = 0
blue[:, :, 2] = 0

red = img.copy()
# set blue and green channel to 0
red[:, :, 0] = 0
red[:, :, 1] = 0

green = img.copy()
# set blue and red channel to 0
green[:, :, 0] = 0
green[:, :, 2] = 0



cv.imshow("Anh Goc", img)

cv.imshow("Blue", blue)
cv.imshow("Red", red)
cv.imshow("Green", green)

cv.waitKey(0)
cv.destroyAllWindows()