# 天文摄影计算器

适用于没有跟踪设备的星空摄影。

只考虑地球自转，忽略其他因素影响。

效率指数反映单张照片中每像素获得的能量。

## 功能

1. 根据焦距、焦比算入瞳；根据焦距、入瞳算焦比；根据焦比、入瞳算焦距。
2. 根据入瞳、波长算瑞利极限。
3. 根据传感器尺寸、像素数算单个像素尺寸（边长）。
4. 根据焦距、传感器尺寸算视场。
5. 根据焦距、单个像素尺寸算角分辨率。
6. 根据角分辨率、目标赤纬、拖线程度算曝光时间；根据角分辨率、目标赤纬、曝光时间算拖线程度。
7. 根据入瞳、角分辨率、曝光时间算效率指数。
8. 根据角分辨率、目标大小算占据像素数；根据角分辨率、占据像素数算目标大小；根据目标大小、占据像素数算角分辨率。

## 效率指数的算法

### 定义

某理想圆望远镜，口径为1米，每像素获得1平方角秒的“标准光”，曝光1秒，积累的能量为1。则单张照片中每像素获得的能量为：

    口径(米) ^ 2 * 角分辨率(角秒) ^ 2 * 曝光时间(秒)

## 更新日志

### v2.0 (20240814)

- 改用WPF界面
- 重整项目结构
- 修复：视场角计算错误
- 优化：效率算法

### v1.1 (20230202)

- 修复：赤纬为90度或拖线过长时出错
- 优化：效率算法
- 新增：几个常见传感器型号

### v1.0 (20230108)

- 发布！
