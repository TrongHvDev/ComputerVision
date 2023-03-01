import cv2 as cv
import numpy as np    
from PIL import Image  
import math

img = cv.imread("Lenna.jpg", cv.IMREAD_COLOR)
imgPIL = Image.open('Lenna.jpg')
HueImg = Image.new(imgPIL.mode, imgPIL.size)
SaturaionImg = Image.new(imgPIL.mode, imgPIL.size)
ValueImg = Image.new(imgPIL.mode, imgPIL.size)
HSIimg = Image.new(imgPIL.mode, imgPIL.size)

class imageSize:
    height, width, _ = img.shape

for x in range(imageSize.width):
    for y in range(imageSize.height):
        R, G, B = imgPIL.getpixel((x, y))
    
        t1 = ((R - G) + (R - B)) / 2
        t2 = math.sqrt((R - G) * (R - G) + (R - B) * (G - B))
        theta = math.acos(t1 / t2)
# tinh H
        H = 0
        if (B <= G):
            H = np.uint8(theta)
        else:
            H = np.uint8(2*math.pi - theta)
        H = np.uint8(H * 180 / math.pi)
# tinh S
        S = np.uint8((1 - 3 * min(R, G, B) / (R + G + B))*255)
# tinh I
        V = np.uint8((R + G + B) / 3)
# hien thi hinh
        HueImg.putpixel((x, y), (H, H, H))  
        SaturaionImg.putpixel((x, y), (S, S, S))  
        ValueImg.putpixel((x, y), (V, V, V))  
        HSIimg.putpixel((x, y), (V, S, H))  


Hue = np.array(HueImg)
Saturation = np.array(SaturaionImg)
Value = np.array(ValueImg)
HSI = np.array(HSIimg)


cv.imshow('Anh Goc', img)
cv.imshow('Hue', Hue)
cv.imshow('Saturation', Saturation)
cv.imshow('Value', Value)
cv.imshow('HSI', HSI)


cv.waitKey(0)
cv.destroyAllWindows()