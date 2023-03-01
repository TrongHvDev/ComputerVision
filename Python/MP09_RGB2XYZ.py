import cv2 as cv
import numpy as np    
from PIL import Image  
import math

img = cv.imread("Lenna.jpg", cv.IMREAD_COLOR)
imgPIL = Image.open('Lenna.jpg')
XImg = Image.new(imgPIL.mode, imgPIL.size)
YImg = Image.new(imgPIL.mode, imgPIL.size)
ZImg = Image.new(imgPIL.mode, imgPIL.size)
XYZimg = Image.new(imgPIL.mode, imgPIL.size)

class imageSize:
    height, width, _ = img.shape

for x in range(imageSize.width):
    for y in range(imageSize.height):
        R, G, B = imgPIL.getpixel((x, y))

        X = np.uint8(0.4124564 * R + 0.3575761 * G + 0.1804375 * B)
        Y = np.uint8(0.2126729 * R + 0.7151522 * G + 0.0721750 * B)
        Z = np.uint8(0.0193339 * R + 0.1191920 * G + 0.9503041 * B)
       
# hien thi hinh
        XImg.putpixel((x, y), (X, X, X))  
        YImg.putpixel((x, y), (Y, Y, Y))  
        ZImg.putpixel((x, y), (Z, Z, Z))  
        XYZimg.putpixel((x, y), (Z, Y, X))  


X = np.array(XImg)
Y = np.array(YImg)
Z = np.array(ZImg)
XYZ = np.array(XYZimg)


cv.imshow('Anh Goc', img)
cv.imshow('X_Img', X)
cv.imshow('Y_Img', Y)
cv.imshow('Z_Img', Z)
cv.imshow('XYZ_Img', XYZ)


cv.waitKey(0)
cv.destroyAllWindows()