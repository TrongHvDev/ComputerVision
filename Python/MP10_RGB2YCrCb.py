import cv2 as cv
import numpy as np    
from PIL import Image  
import math

img = cv.imread("Lenna.jpg", cv.IMREAD_COLOR)
imgPIL = Image.open('Lenna.jpg')
YImg = Image.new(imgPIL.mode, imgPIL.size)
CrImg = Image.new(imgPIL.mode, imgPIL.size)
CbImg = Image.new(imgPIL.mode, imgPIL.size)
YCrCbimg = Image.new(imgPIL.mode, imgPIL.size)

class imageSize:
    height, width, _ = img.shape

for x in range(imageSize.width):
    for y in range(imageSize.height):
        R, G, B = imgPIL.getpixel((x, y))

        Y = np.uint8(16 + (65.738 / 256) * R + (129.057 / 256) * G + (25.064 / 256) * B)
        Cr = np.uint8(128 - (37.945 / 256) * R - (74.494 / 256) * G + (112.439 / 256) * B)
        Cb = np.uint8(128 + (112.439 / 256) * R - (94.154 / 256) * G - (18.285 / 256) * B)
       
# hien thi hinh
        YImg.putpixel((x, y), (Y, Y, Y))  
        CrImg.putpixel((x, y), (Cr, Cr, Cr))  
        CbImg.putpixel((x, y), (Cb, Cb, Cb))  
        YCrCbimg.putpixel((x, y), (Cb, Cr, Y))  


Y = np.array(YImg)
Cr = np.array(CrImg)
Cb = np.array(CbImg)
YCrCb = np.array(YCrCbimg)


cv.imshow('Anh Goc', img)
cv.imshow('Y_Img', Y)
cv.imshow('Cr_Img', Cr)
cv.imshow('Cb_Img', Cb)
cv.imshow('YCrCb_Img', YCrCb)


cv.waitKey(0)
cv.destroyAllWindows()