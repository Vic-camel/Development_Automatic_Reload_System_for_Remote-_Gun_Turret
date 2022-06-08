> <b>人機介面</b>及<b>機械手臂</b>控制皆為<b>C#</b>

# 人機介面
* 人機介面功能設計
  * Connect -->透過乙太網路連接IP Cam
  * Fire -->擊發子彈
  * Reload -->按下後啟動換彈系統
  * Number of Bullets -->顯示剩餘彈藥數
  
![](https://i.imgur.com/9efKjDe.png)

## 引入IP Cam 影像至人機介面
詳見<a href="https://youtu.be/GvE47qOUVBo">教學</a>

<div style="background-color:green;">
 
注意
 
1. visual_studio 安裝 visioforge 套件

2. 注意套件版本:15.1.5

 ![](https://i.imgur.com/b5iQUsQ.png)

</div>

## 各部件連線
* 按下人機介面上的Fire後至槍塔系統中扣板機系統轉動馬達
* 按下人機介面上的Reload後，人機介面命令夾爪夾取
* 按下人機介面上的Reload後，人機介面命令啟動視覺辨識

上述操控均透過<b style="color:darkblue">共同網域</b>、<b style="color:darkblue">Socket</b>及<b style="color:darkblue">Hub</b>達成

## 顯示彈藥數量
僅僅是模擬數字

# 換彈系統(機械手臂)
>本實作採用 HIWIN RA605 機械手臂

## 開發過程
<b>環境建置</b>
* <a href="https://hackmd.io/@NDU-CCIT-1116014/BJx_BMIMt">C#引入機械手臂dll檔</a>
* <a href="https://hackmd.io/@NDU-CCIT-1116014/rJ4Oj1MFK">機械手臂運用淺談</a>

<b>座標轉換策略</b>

![](https://i.imgur.com/nxOwQ3n.png)
本實作<a href="https://hackmd.io/P1baFeJpQ3qIABO3oAaHiA?both">像素座標與世界座標轉換策略</a>
