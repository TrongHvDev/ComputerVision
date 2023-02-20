import cv2 as cv    
import numpy as np    
from PIL import Image  
import matplotlib.pylab as plt

img = cv.imread('bird_small.jpg', cv.IMREAD_COLOR)
imgPIL = Image.open('bird_small.jpg')
newImg = Image.new(imgPIL.mode, imgPIL.size)

class imageSize:
    height, width, _ = img.shape

def RGB2GRAY():
    for x in range(imageSize.width):
        for y in range(imageSize.height):
            R, G, B = imgPIL.getpixel((x, y))
            gray = np.uint8((R + G + B)/3)
            newImg.putpixel((x, y), (gray, gray, gray))
    return newImg

def HistogramCalc(grayImg):
    his = np.zeros(256)
    for x in range(imageSize.width):
        for y in range(imageSize.height):
            gR, gG, gB = grayImg.getpixel((x, y))
            his[gR] += 1
    return his

def showHistogram(his):
    w = 5
    h = 4
    plt.figure('Bieu do Histogram anh xam', figsize=((w, h)), dpi=100)
    dX = np.zeros(256)
    dX = np.linspace(0, 256, 256)
    plt.plot(dX, his, color = 'red')
    plt.title('Bieu do Histogram')
    plt.xlabel('Gia tri muc xam')
    plt.ylabel('So diem cung gia tri muc xam')
    plt.show()


    
      
his = HistogramCalc(RGB2GRAY())
  
grayImg = np.array(newImg)       
cv.imshow('Anh Goc RGB: ', grayImg)

showHistogram(his) 


cv.waitKey(0)
cv.destroyAllWindows()
    

