import cv2 as cv       
from PIL import Image 
import numpy as np    
import matplotlib.pyplot as plt   


img = cv.imread('lenna.jpg', cv.IMREAD_COLOR)
imgPIL = Image.open('lenna.jpg')

binary_img = Image.new(imgPIL.mode, imgPIL.size)

width =binary_img.size[0]
height = binary_img.size[1]

#---------------------------------------------------------------------
# plot histogram to find thresould
# gray_his = cv.cvtColor(img, cv.COLOR_BGR2GRAY)
# hist = cv.calcHist([gray_his], [0], None, [256], [0,256])
# x = range(256)
# plt.plot(x, hist)
# plt.show()
#----------------------------------------------------------------------

thresould = 120
for x in range(width):
    for y in range(height):
        R, G, B = imgPIL.getpixel((x, y))

        gray = np.uint8(0.2126*R + 0.7152*G + 0.0722*B)
    
        if (gray < thresould):
            binary_img.putpixel((x, y), (0, 0, 0))
        else:
            binary_img.putpixel((x, y), (255, 255, 255))
        


hinhnhiphan = np.array(binary_img)

cv.imshow('Hinh mau RGB', img)
cv.imshow('Hinh nhi phan Binary', hinhnhiphan)

cv.waitKey(0)
cv.destroyAllWindows()