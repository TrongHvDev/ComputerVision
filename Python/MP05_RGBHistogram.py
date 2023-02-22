import cv2 as cv    
import numpy as np    
from PIL import Image  
import matplotlib.pylab as plt

img = cv.imread('bird_small.jpg', cv.IMREAD_COLOR)
imgPIL = Image.open('bird_small.jpg')
RedImg = Image.new(imgPIL.mode, imgPIL.size)
BlueImg = Image.new(imgPIL.mode, imgPIL.size)
GreenImg = Image.new(imgPIL.mode, imgPIL.size)

class imageSize:
    height, width, _ = img.shape


for x in range(imageSize.width):
    for y in range(imageSize.height):
        R, G, B = imgPIL.getpixel((x, y))
        RedImg.putpixel((x, y), (R, R, R))
        BlueImg.putpixel((x, y), (B, B, B))
        GreenImg.putpixel((x, y), (G, G, G))


def HistogramCalc(imgPIL):
    his = np.zeros((3, 256), np.uint8)
    hisR = np.zeros(256)
    hisG = np.zeros(256)
    hisB = np.zeros(256)

    for x in range(imageSize.width):
        for y in range(imageSize.height):
            R, G, B = imgPIL.getpixel((x,y))
            hisR[R] += 1 #Trong hinh xam thi R
            hisG[G] += 1 #Trong hinh xam thi G
            hisB[B] += 1 #Trong hinh xam thi B
    his = [hisR, hisG, hisB]    

    return his


def showHistogram(his):
    w = 5
    h = 4
    plt.figure('Bieu do Histogram anh xam', figsize=((w, h)), dpi=100)
    dX = np.zeros(256)
    dX = np.linspace(0, 256, 256)
    plt.plot(dX, his[0], color = 'red')
    plt.plot(dX, his[1], color = 'green')
    plt.plot(dX, his[2], color = 'blue')
    plt.title('Biểu đồ histogram ảnh màu RGB')
    plt.show()


    
      
his = HistogramCalc(imgPIL)
cv.imshow('Anh Goc', img) 

showHistogram(his)


cv.waitKey(0)
cv.destroyAllWindows()
    

