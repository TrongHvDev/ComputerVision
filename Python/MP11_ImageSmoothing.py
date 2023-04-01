import cv2 as cv
import numpy as np    
from PIL import Image  

# img = cv.imread("Lenna.jpg", cv.IMREAD_COLOR)
# imgPIL = Image.open('Lenna.jpg')

img = cv.imread("bird_small.jpg", cv.IMREAD_COLOR)
imgPIL = Image.open('bird_small.jpg')

class imageSize:
    height, width, _ = img.shape

def ImageSmoothing(imgPIL, mask):
    if mask == 3:   
        offset = 1
    if mask == 5:   
        offset = 2
    if mask == 7:   
        offset = 3
    if mask == 9:   
        offset = 4        
    SmoothedImage = Image.new(imgPIL.mode, imgPIL.size)
    for x in range(offset, imageSize.width - offset):
        for y in range(offset, imageSize.height - offset):
            #Lay gia tri cac diem anh tai vi tri (x,y)
            Rs = 0
            Gs = 0
            Bs = 0
            for i in range(x - offset,x + offset + 1):
                for j in range(y - offset,y + offset + 1):
                    #Lay gia tri cac diem anh tai vi tri (x,y)
                    R, G, B = imgPIL.getpixel((i,j))
                    Rs += R
                    Gs += G
                    Bs += B
            K = mask * mask
            Rs = np.uint8(Rs/K)   
            Bs = np.uint8(Bs/K)
            Gs = np.uint8(Gs/K)

            SmoothedImage.putpixel((x,y),(Bs, Gs, Rs))

    SmoothedImage3x3_CV = np.array(SmoothedImage)
    return SmoothedImage3x3_CV


img_3x3 = ImageSmoothing(imgPIL, 3)
img_5x5 = ImageSmoothing(imgPIL, 5)
img_7x7 = ImageSmoothing(imgPIL, 7)
img_9x9 = ImageSmoothing(imgPIL, 9)

cv.imshow('Anh Goc', img)
cv.imshow('Anh lam muot 3x3', img_3x3)
cv.imshow('Anh lam muot 5x5', img_5x5)
cv.imshow('Anh lam muot 7x7', img_7x7)
cv.imshow('Anh lam muot 9x9', img_9x9)
cv.waitKey(0)
cv.destroyAllWindows()