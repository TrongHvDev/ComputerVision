import cv2 as cv
import numpy as np    
from PIL import Image

img = cv.imread("Lenna.jpg", cv.IMREAD_COLOR)
imgPIL = Image.open('Lenna.jpg')

x1 = int(input("Nhập x1: "))
x2 = int(input("Nhập x2: "))
y1 = int(input("Nhập y1: "))
y2 = int(input("Nhập y2: "))
nguong = int(input("Nhập ngưỡng: "))

ImageSegmentation = Image.new(imgPIL.mode, imgPIL.size)
width = ImageSegmentation.size[0] 
height = ImageSegmentation.size[1]

averageRGB = np.zeros(3, float)
for i in range(x1 ,x2 + 1):
    for j in range(y1 ,y2 + 1):
        #Lay gia tri cac diem anh tai vi tri (x,y)
        R, G, B = imgPIL.getpixel((i,j))

        averageRGB[0] += R
        averageRGB[1] += G
        averageRGB[2] += B

NumberPoints = np.abs(x2 - x1)*np.abs(y2 - y1)
averageRGB[0] = averageRGB[0]/NumberPoints
averageRGB[1] = averageRGB[1]/NumberPoints
averageRGB[2] = averageRGB[2]/NumberPoints

for x in range(width):
    for y in range(height):
        zR,zG,zB = imgPIL.getpixel((x,y))

        D_za = np.sqrt((zR - averageRGB[0])*(zR - averageRGB[0]) + (zG - averageRGB[1])*(zG - averageRGB[1]) + (zB - averageRGB[2])*(zB - averageRGB[2]))

        if (D_za < nguong):
            zR = 255
            zB = 255
            zG = 255
        
        ImageSegmentation.putpixel((x, y), (np.uint8(zB), np.uint8(zG), np.uint8(zR)))
img_Segmentation = np.array(ImageSegmentation)

cv.imshow('Anh Goc', img)
cv.imshow('Anh sau khi phan doan', img_Segmentation)
cv.waitKey(0)
cv.destroyAllWindows()