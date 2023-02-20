import cv2        
import numpy as np    
from PIL import Image   


img = cv2.imread('lenna.jpg', cv2.IMREAD_COLOR)

imgPIL = Image.open('lenna.jpg')


average = Image.new(imgPIL.mode, imgPIL.size)
lightness = Image.new(imgPIL.mode, imgPIL.size)
luminance = Image.new(imgPIL.mode, imgPIL.size)

class imageSize:
    height, width, _ = img.shape

for x in range(imageSize.width):
    for y in range(imageSize.height):
        R, G, B = imgPIL.getpixel((x, y))
#average method
        gray = np.uint8((R + G + B) / 3)

#lightness method        
        MIN = min(R, G, B)
        MAX = max(R, G, B)
        light = np.uint8((MIN + MAX) / 2)

#luminance method       
        lumi = np.uint8(0.2126*R + 0.7152*G + 0.0722*B)

      
        average.putpixel((x, y), (gray, gray, gray))
        lightness.putpixel((x, y), (light, light, light))
        luminance.putpixel((x, y), (lumi, lumi, lumi))
        


avg_img= np.array(average)
light_img = np.array(lightness)
lumi_img = np.array(luminance)

cv2.imshow('Hinh mau RGB', img)
cv2.imshow('Hinh muc xam Average', avg_img)
cv2.imshow('Hinh muc xam Lightness', light_img)
cv2.imshow('Hinh muc xam Luminance', lumi_img)

cv2.waitKey(0)


cv2.destroyAllWindows()