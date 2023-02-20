import cv2        
import numpy as np    
from PIL import Image   


img = cv2.imread('lenna.jpg', cv2.IMREAD_COLOR)
imgPIL = Image.open('lenna.jpg')
average = Image.new(imgPIL.mode, imgPIL.size)

class imageSize:
    height, width, _ = img.shape

for x in range(imageSize.width):
    for y in range(imageSize.height):
        R, G, B = imgPIL.getpixel((x, y))
#average method
        gray = np.uint8((R + G + B) / 3)  
        average.putpixel((x, y), (gray, gray, gray))



avg_img= np.array(average)


cv2.imshow('Hinh mau RGB', img)
cv2.imshow('Hinh muc xam Average', avg_img)
cv2.waitKey(0)
cv2.destroyAllWindows()