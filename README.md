# Development Automatic Reload System for Remote Gun Turret based on Robotic Arm and Visual Recognition
基於<b>機械手臂</b>與<b>視覺辨識</b>實現適用於遠端遙控槍塔之<b>彈藥自動再裝填系統</b>

# 實作成員
組員:駱皇安、簡育賢、洪嘉澤、楊詠絜

指導老師:藍建武 老師

# 實作介紹
<b>實作名稱:</b>基於<b>機械手臂</b>與<b>視覺辨識</b>實現適用於遠端遙控槍塔之<b>彈藥自動再裝填系統</b>

<b>實作用途:</b>
> 本實作目的為開發機槍槍塔之自動換彈系統，亦即在各國研究的遠端遙控槍塔上加入彈藥自動再裝填系統達到非人員親自到達戰爭前線換彈之目的。

<b>場景構想:</b>

![](https://i.imgur.com/IH2Gg2J.png)

本實作目的為開發讓士兵僅需位於遠處，便能從使用者端上的人機介面清楚得知目前即時戰況，一旦有需求時便能按下人機介面上擊發鈕，遠端遙控機槍擊發彈藥；待子彈用罄時，按下人機介面上的換彈鈕，便能呼叫機械手臂自動完成一系列的彈藥換彈程序，以提供下一波攻擊。<b>本實作運用場景為城鎮戰、灘岸防守亦或子母堡內人員可位於後方母堡進行遠方操控達到戰爭前線無人員操作的目的。</b>

<b>成果影片:</b>https://youtu.be/3VSAauvACv4

# 系統簡介

![](https://i.imgur.com/PVHdgyw.png)
由上圖中場景構想，繪製<b style="color:darkred">系統架構圖</b>
本實作以<b>槍塔系統</b>、<b>彈藥自動再裝填系統</b>以及<b>使用者端</b>三部分實現。
![](https://i.imgur.com/RTtbpdD.png)

<b style="color:darkblue">第一部分:槍塔系統</b>

為驗證本計畫開發之換彈自動再裝填系統，亦規劃製作一遠端遙控槍塔平台固定槍枝和擊發功能來進行自動換彈的測試與驗證，而該槍塔平台可透過人機介面進行遠端操控並加裝 IP Cam 回傳即時戰況至使用者端。

<b style="color:darkblue">第二部分:彈藥自動再裝填系統</b>

此部分為計畫之核心，使用視覺辨識技術辨識彈鏈姿態及位置，同時運用六軸機械手臂及自製夾爪夾取彈鏈以實現自動再裝填之功能。

<b style="color:darkblue">第三部分:使用者端</b>

開發人機介面內部功能包含擊發、即時影像及預設的固定剩餘彈藥數量，一旦彈藥數量用罄後，使用者可呼叫自動換彈系統進行換彈，當彈藥更換完畢後，即可持續進行射擊。

# 操作流程
![](https://i.imgur.com/wMEDGIx.png)
![](https://i.imgur.com/QfvRiB3.png)

# 如何實現
* 各系統實現方式詳見<b>src</b>檔案(source code file)
* 各系統溝通及連線方式
透過<b>Hub</b>、<b>乙太網路</b>及<b>Socket</b>連結各系統
![](https://i.imgur.com/VuIV4BR.jpg)

# Dependencies / Requirements (用到哪些軟體、開發板、模組、工具...)
* 軟體
  * Arduino
  * Python
  * OpenCV
  * C#
* 硬體
  * Jetson Nano 2GB
  * Arduino Uno
  * 降壓模組
  * IP Cam
  * 機械手臂
  * 伺服馬達
  * 夾爪模組
* 工具
  * 3D列印
