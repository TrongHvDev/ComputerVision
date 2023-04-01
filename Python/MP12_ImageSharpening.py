import cv2 as cv
import numpy as np    
from PIL import Image  

# img = cv.imread("Lenna.jpg", cv.IMREAD_COLOR)
# imgPIL = Image.open('Lenna.jpg')

img = cv.imread("bird_small.jpg", cv.IMREAD_COLOR)
imgPIL = Image.open('bird_small.jpg')

class imageSize:
    height, width, _ = img.shape

f = np.zeros((3,5), float)

SharpenedImage = Image.new(imgPIL.mode, imgPIL.size)
for x in range(1, imageSize.width - 1):
    for y in range(1, imageSize.height - 1):
#Tao 5 bien gan gia tri cua diem anh hien tai va cua 4 diem xung quanh        
        f[0,0], f[1,0], f[2,0] = imgPIL.getpixel((x, y))
        f[0,1], f[1,1], f[2,1] = imgPIL.getpixel((x - 1, y))
        f[0,2], f[1,2], f[2,2] = imgPIL.getpixel((x + 1, y))
        f[0,3], f[1,3], f[2,3] = imgPIL.getpixel((x, y - 1))
        f[0,4], f[1,4], f[2,4] = imgPIL.getpixel((x, y + 1))

        g = np.zeros(3,float)
        for k in range(3):
            g[k] = f[k, 0] + 4 * f[k, 0] - f[k,1] - f[k, 2] - f[k, 3] - f[k, 4]
            if (g[k] < 0):
                g[k] = 0
            if (g[k] > 255):
                g[k] = 255
        
        SharpenedImage.putpixel((x,y),(np.uint8(g[2]), np.uint8(g[1]), np.uint8(g[0])))


img_Sharpened = np.array(SharpenedImage)

cv.imshow('Anh Goc', img)
cv.imshow('Sharpened Image', img_Sharpened)
cv.waitKey(0)
cv.destroyAllWindows()