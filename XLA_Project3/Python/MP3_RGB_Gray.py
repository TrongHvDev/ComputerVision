import cv2        
import numpy as np    
from PIL import Image   


img = cv2.imread('lenna.jpg', cv2.IMREAD_COLOR)

imgPIL = Image.open('lenna.jpg')


average = Image.new(imgPIL.mode, imgPIL.size)
average1 = Image.new(imgPIL.mode, imgPIL.size)
average2 = Image.new(imgPIL.mode, imgPIL.size)

width =average.size[0]
height = average.size[1]
width =average1.size[0]
height = average1.size[1]
width =average2.size[0]
height = average2.size[1]


for x in range(width):
    for y in range(height):
        R, G, B = imgPIL.getpixel((x, y))

    
        gray = np.uint8((R + G + B) / 3)

        
        MIN = min(R, G, B)
        MAX =max(R, G, B)
        gray1 = np.uint8((MIN + MAX) / 2)

       
        gray2 = np.uint8(0.2126*R + 0.7152*G + 0.0722*B)

      
        average.putpixel((x, y), (gray, gray, gray))
        average1.putpixel((x, y), (gray1, gray1, gray1))
        average2.putpixel((x, y), (gray2, gray2, gray2))
        


anhmucxam = np.array(average)
anhmucxam1 = np.array(average1)
anhmucxam2 = np.array(average2)

cv2.imshow('Hinh mau RGB', img)
cv2.imshow('Hinh muc xam Average', anhmucxam)
cv2.imshow('Hinh muc xam Lightness', anhmucxam1)
cv2.imshow('Hinh muc xam Luminance', anhmucxam2)

cv2.waitKey(0)


cv2.destroyAllWindows()