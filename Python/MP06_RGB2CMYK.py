import cv2 as cv
import numpy as np    
from PIL import Image  
import math

img = cv.imread("Lenna.jpg", cv.IMREAD_COLOR)
imgPIL = Image.open('Lenna.jpg')
CyanImg = Image.new(imgPIL.mode, imgPIL.size)
MagentaImg = Image.new(imgPIL.mode, imgPIL.size)
YellowImg = Image.new(imgPIL.mode, imgPIL.size)
BlackImg = Image.new(imgPIL.mode, imgPIL.size)

class imageSize:
    height, width, _ = img.shape

for x in range(imageSize.width):
    for y in range(imageSize.height):
        R, G, B = imgPIL.getpixel((x, y))
        # BGR image
        CyanImg.putpixel((x, y), (B, G, 0))     # set RED = 0
        MagentaImg.putpixel((x, y), (B, 0, R))     # set Green = 0
        YellowImg.putpixel((x, y), (0, G, R))     # set Blue = 0

        K = min(R, G, B)
        BlackImg.putpixel((x, y), (K, K, K))     

Cyan = np.array(CyanImg)
Magenta = np.array(MagentaImg)
Yellow = np.array(YellowImg)
Black = np.array(BlackImg)


cv.imshow('Anh Goc', img)
cv.imshow('Cyan', Cyan)
cv.imshow('Magenta', Magenta)
cv.imshow('Yellow', Yellow)
cv.imshow('Black', Black)


cv.waitKey(0)
cv.destroyAllWindows()