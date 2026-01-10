> PS：Step: 8920000时做了以下修改：
> - Unity界面，maxstep修改成5000并在cs文件把`FixedUpdate()` 中 `tt>=1000`注释掉。（原代码中step=1000后机器人会重置）
```cs
if (Mathf.Abs(EulerTrans(body.eulerAngles[0])) > 20f || Mathf.Abs(EulerTrans(body.eulerAngles[2])) > 20f ) // || tt>=1000
```


[INFO] gewu. Step: 20000. Time Elapsed: 33.207 s. Mean Reward: -247.345. Std of Reward: 67.133. Training.
[INFO] gewu. Step: 40000. Time Elapsed: 46.929 s. Mean Reward: -246.924. Std of Reward: 63.251. Training.
[INFO] gewu. Step: 60000. Time Elapsed: 60.330 s. Mean Reward: -234.414. Std of Reward: 59.735. Training.
[INFO] gewu. Step: 80000. Time Elapsed: 71.527 s. Mean Reward: -218.697. Std of Reward: 61.496. Training.
[INFO] gewu. Step: 100000. Time Elapsed: 82.226 s. Mean Reward: -204.102. Std of Reward: 64.347. Training.
[INFO] gewu. Step: 120000. Time Elapsed: 93.049 s. Mean Reward: -192.520. Std of Reward: 61.096. Training.
[INFO] gewu. Step: 140000. Time Elapsed: 104.262 s. Mean Reward: -169.942. Std of Reward: 66.056. Training.
[INFO] gewu. Step: 160000. Time Elapsed: 115.041 s. Mean Reward: -174.957. Std of Reward: 57.057. Training.
[INFO] gewu. Step: 180000. Time Elapsed: 127.932 s. Mean Reward: -162.583. Std of Reward: 67.059. Training.
[INFO] gewu. Step: 200000. Time Elapsed: 141.858 s. Mean Reward: -142.169. Std of Reward: 59.892. Training.
[INFO] gewu. Step: 220000. Time Elapsed: 155.199 s. Mean Reward: -117.067. Std of Reward: 59.626. Training.
[INFO] gewu. Step: 240000. Time Elapsed: 168.480 s. Mean Reward: -100.617. Std of Reward: 63.310. Training.
[INFO] gewu. Step: 260000. Time Elapsed: 181.887 s. Mean Reward: -79.068. Std of Reward: 52.533. Training.
[INFO] gewu. Step: 280000. Time Elapsed: 195.154 s. Mean Reward: -54.224. Std of Reward: 54.085. Training.
[INFO] gewu. Step: 300000. Time Elapsed: 208.331 s. Mean Reward: -45.332. Std of Reward: 52.323. Training.
[INFO] gewu. Step: 320000. Time Elapsed: 221.852 s. Mean Reward: -29.950. Std of Reward: 51.601. Training.
[INFO] gewu. Step: 340000. Time Elapsed: 235.092 s. Mean Reward: -8.273. Std of Reward: 30.197. Training.
[INFO] gewu. Step: 360000. Time Elapsed: 248.279 s. Mean Reward: 1.771. Std of Reward: 35.267. Training.
[INFO] gewu. Step: 380000. Time Elapsed: 260.050 s. Mean Reward: 14.782. Std of Reward: 32.214. Training.
[INFO] gewu. Step: 400000. Time Elapsed: 271.072 s. Mean Reward: 18.313. Std of Reward: 42.757. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-399994.onnx
[INFO] gewu. Step: 420000. Time Elapsed: 281.776 s. Mean Reward: 24.980. Std of Reward: 40.186. Training.
[INFO] gewu. Step: 440000. Time Elapsed: 292.484 s. Mean Reward: 35.192. Std of Reward: 24.345. Training.
[INFO] gewu. Step: 460000. Time Elapsed: 303.133 s. Mean Reward: 44.758. Std of Reward: 26.648. Training.
[INFO] gewu. Step: 480000. Time Elapsed: 313.976 s. Mean Reward: 50.979. Std of Reward: 29.965. Training.
[INFO] gewu. Step: 500000. Time Elapsed: 324.681 s. Mean Reward: 52.471. Std of Reward: 43.557. Training.
[INFO] gewu. Step: 520000. Time Elapsed: 335.524 s. Mean Reward: 63.057. Std of Reward: 32.965. Training.
[INFO] gewu. Step: 540000. Time Elapsed: 346.320 s. Mean Reward: 69.982. Std of Reward: 25.983. Training.
[INFO] gewu. Step: 560000. Time Elapsed: 357.325 s. Mean Reward: 71.391. Std of Reward: 26.751. Training.
[INFO] gewu. Step: 580000. Time Elapsed: 368.202 s. Mean Reward: 79.459. Std of Reward: 27.519. Training.
[INFO] gewu. Step: 600000. Time Elapsed: 378.754 s. Mean Reward: 77.432. Std of Reward: 33.171. Training.
[INFO] gewu. Step: 620000. Time Elapsed: 389.715 s. Mean Reward: 82.114. Std of Reward: 44.491. Training.
[INFO] gewu. Step: 640000. Time Elapsed: 400.460 s. Mean Reward: 93.163. Std of Reward: 27.684. Training.
[INFO] gewu. Step: 660000. Time Elapsed: 411.276 s. Mean Reward: 89.957. Std of Reward: 34.912. Training.
[INFO] gewu. Step: 680000. Time Elapsed: 421.963 s. Mean Reward: 98.664. Std of Reward: 36.343. Training.
[INFO] gewu. Step: 700000. Time Elapsed: 433.625 s. Mean Reward: 95.775. Std of Reward: 35.665. Training.
[INFO] gewu. Step: 720000. Time Elapsed: 441.073 s. Mean Reward: 102.894. Std of Reward: 26.052. Training.
[INFO] gewu. Step: 740000. Time Elapsed: 451.832 s. Mean Reward: 104.737. Std of Reward: 21.904. Training.
[INFO] gewu. Step: 760000. Time Elapsed: 462.769 s. Mean Reward: 112.042. Std of Reward: 21.008. Training.
[INFO] gewu. Step: 780000. Time Elapsed: 476.121 s. Mean Reward: 110.150. Std of Reward: 45.850. Training.
[INFO] gewu. Step: 800000. Time Elapsed: 489.618 s. Mean Reward: 112.962. Std of Reward: 32.795. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-799885.onnx
[INFO] gewu. Step: 820000. Time Elapsed: 503.027 s. Mean Reward: 120.870. Std of Reward: 24.702. Training.
[INFO] gewu. Step: 840000. Time Elapsed: 516.626 s. Mean Reward: 119.178. Std of Reward: 26.704. Training.
[INFO] gewu. Step: 860000. Time Elapsed: 530.330 s. Mean Reward: 113.289. Std of Reward: 66.219. Training.
[INFO] gewu. Step: 880000. Time Elapsed: 541.706 s. Mean Reward: 114.159. Std of Reward: 81.278. Training.
[INFO] gewu. Step: 900000. Time Elapsed: 552.838 s. Mean Reward: 130.716. Std of Reward: 65.772. Training.
[INFO] gewu. Step: 920000. Time Elapsed: 563.246 s. Mean Reward: 122.305. Std of Reward: 69.044. Training.
[INFO] gewu. Step: 940000. Time Elapsed: 574.420 s. Mean Reward: 134.996. Std of Reward: 39.736. Training.
[INFO] gewu. Step: 960000. Time Elapsed: 585.607 s. Mean Reward: 140.792. Std of Reward: 26.675. Training.
[INFO] gewu. Step: 980000. Time Elapsed: 598.876 s. Mean Reward: 138.972. Std of Reward: 51.663. Training.
[INFO] gewu. Step: 1000000. Time Elapsed: 612.551 s. Mean Reward: 144.266. Std of Reward: 51.458. Training.
[INFO] gewu. Step: 1020000. Time Elapsed: 626.625 s. Mean Reward: 152.203. Std of Reward: 24.761. Training.
[INFO] gewu. Step: 1040000. Time Elapsed: 639.924 s. Mean Reward: 158.391. Std of Reward: 26.709. Training.
[INFO] gewu. Step: 1060000. Time Elapsed: 653.662 s. Mean Reward: 160.849. Std of Reward: 38.644. Training.
[INFO] gewu. Step: 1080000. Time Elapsed: 667.162 s. Mean Reward: 164.807. Std of Reward: 27.490. Training.
[INFO] gewu. Step: 1100000. Time Elapsed: 680.672 s. Mean Reward: 174.369. Std of Reward: 58.137. Training.
[INFO] gewu. Step: 1120000. Time Elapsed: 694.233 s. Mean Reward: 161.611. Std of Reward: 77.561. Training.
[INFO] gewu. Step: 1140000. Time Elapsed: 707.911 s. Mean Reward: 179.414. Std of Reward: 64.531. Training.
[INFO] gewu. Step: 1160000. Time Elapsed: 722.103 s. Mean Reward: 176.419. Std of Reward: 67.503. Training.
[INFO] gewu. Step: 1180000. Time Elapsed: 734.560 s. Mean Reward: 193.359. Std of Reward: 69.576. Training.
[INFO] gewu. Step: 1200000. Time Elapsed: 745.390 s. Mean Reward: 187.437. Std of Reward: 40.618. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-1199806.onnx
[INFO] gewu. Step: 1220000. Time Elapsed: 756.556 s. Mean Reward: 192.922. Std of Reward: 46.951. Training.
[INFO] gewu. Step: 1240000. Time Elapsed: 770.382 s. Mean Reward: 196.458. Std of Reward: 38.708. Training.
[INFO] gewu. Step: 1260000. Time Elapsed: 782.387 s. Mean Reward: 200.493. Std of Reward: 41.682. Training.
[INFO] gewu. Step: 1280000. Time Elapsed: 794.383 s. Mean Reward: 206.241. Std of Reward: 52.769. Training.
[INFO] gewu. Step: 1300000. Time Elapsed: 808.745 s. Mean Reward: 205.458. Std of Reward: 63.616. Training.
[INFO] gewu. Step: 1320000. Time Elapsed: 823.373 s. Mean Reward: 200.958. Std of Reward: 29.977. Training.
[INFO] gewu. Step: 1340000. Time Elapsed: 838.618 s. Mean Reward: 225.316. Std of Reward: 49.550. Training.
[INFO] gewu. Step: 1360000. Time Elapsed: 852.889 s. Mean Reward: 230.599. Std of Reward: 57.927. Training.
[INFO] gewu. Step: 1380000. Time Elapsed: 867.656 s. Mean Reward: 250.987. Std of Reward: 99.357. Training.
[INFO] gewu. Step: 1400000. Time Elapsed: 876.513 s. Mean Reward: 226.346. Std of Reward: 112.682. Training.
[INFO] gewu. Step: 1420000. Time Elapsed: 890.923 s. Mean Reward: 225.002. Std of Reward: 58.100. Training.
[INFO] gewu. Step: 1440000. Time Elapsed: 905.982 s. Mean Reward: 243.938. Std of Reward: 100.633. Training.
[INFO] gewu. Step: 1460000. Time Elapsed: 920.023 s. Mean Reward: 314.169. Std of Reward: 148.049. Training.
[INFO] gewu. Step: 1480000. Time Elapsed: 935.586 s. Mean Reward: 277.291. Std of Reward: 122.607. Training.
[INFO] gewu. Step: 1500000. Time Elapsed: 950.064 s. Mean Reward: 292.033. Std of Reward: 94.508. Training.
[INFO] gewu. Step: 1520000. Time Elapsed: 964.779 s. Mean Reward: 296.292. Std of Reward: 162.012. Training.
[INFO] gewu. Step: 1540000. Time Elapsed: 977.245 s. Mean Reward: 306.422. Std of Reward: 129.461. Training.
[INFO] gewu. Step: 1560000. Time Elapsed: 989.318 s. Mean Reward: 293.068. Std of Reward: 96.281. Training.
[INFO] gewu. Step: 1580000. Time Elapsed: 1002.274 s. Mean Reward: 409.656. Std of Reward: 178.595. Training.
[INFO] gewu. Step: 1600000. Time Elapsed: 1015.072 s. Mean Reward: 393.396. Std of Reward: 170.618. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-1599446.onnx
[INFO] gewu. Step: 1620000. Time Elapsed: 1028.979 s. Mean Reward: 372.351. Std of Reward: 162.938. Training.
[INFO] gewu. Step: 1640000. Time Elapsed: 1042.126 s. Mean Reward: 365.870. Std of Reward: 166.405. Training.
[INFO] gewu. Step: 1660000. Time Elapsed: 1057.410 s. Mean Reward: 356.476. Std of Reward: 171.575. Training.
[INFO] gewu. Step: 1680000. Time Elapsed: 1071.354 s. Mean Reward: 523.097. Std of Reward: 243.536. Training.
[INFO] gewu. Step: 1700000. Time Elapsed: 1081.836 s. Mean Reward: 600.846. Std of Reward: 162.816. Training.
[INFO] gewu. Step: 1720000. Time Elapsed: 1092.021 s. Mean Reward: 523.546. Std of Reward: 218.203. Training.
[INFO] gewu. Step: 1740000. Time Elapsed: 1103.335 s. Mean Reward: 584.274. Std of Reward: 194.995. Training.
[INFO] gewu. Step: 1760000. Time Elapsed: 1114.479 s. Mean Reward: 559.250. Std of Reward: 202.020. Training.
[INFO] gewu. Step: 1780000. Time Elapsed: 1125.030 s. Mean Reward: 668.917. Std of Reward: 76.587. Training.
[INFO] gewu. Step: 1800000. Time Elapsed: 1135.371 s. Mean Reward: 595.267. Std of Reward: 180.990. Training.
[INFO] gewu. Step: 1820000. Time Elapsed: 1145.993 s. Mean Reward: 633.920. Std of Reward: 163.741. Training.
[INFO] gewu. Step: 1840000. Time Elapsed: 1156.556 s. Mean Reward: 676.862. Std of Reward: 94.753. Training.
[INFO] gewu. Step: 1860000. Time Elapsed: 1163.061 s. Mean Reward: 627.429. Std of Reward: 149.427. Training.
[INFO] gewu. Step: 1880000. Time Elapsed: 1175.144 s. Mean Reward: 589.444. Std of Reward: 215.502. Training.
[INFO] gewu. Step: 1900000. Time Elapsed: 1186.377 s. Mean Reward: 558.026. Std of Reward: 196.154. Training.
[INFO] gewu. Step: 1920000. Time Elapsed: 1199.183 s. Mean Reward: 539.644. Std of Reward: 201.528. Training.
[INFO] gewu. Step: 1940000. Time Elapsed: 1210.335 s. Mean Reward: 528.818. Std of Reward: 249.208. Training.
[INFO] gewu. Step: 1960000. Time Elapsed: 1221.307 s. Mean Reward: 642.265. Std of Reward: 126.301. Training.
[INFO] gewu. Step: 1980000. Time Elapsed: 1231.707 s. Mean Reward: 650.978. Std of Reward: 173.232. Training.
[INFO] gewu. Step: 2000000. Time Elapsed: 1241.715 s. Mean Reward: 595.714. Std of Reward: 195.992. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-1999877.onnx
[INFO] gewu. Step: 2020000. Time Elapsed: 1252.432 s. Mean Reward: 571.585. Std of Reward: 243.177. Training.
[INFO] gewu. Step: 2040000. Time Elapsed: 1263.274 s. Mean Reward: 534.233. Std of Reward: 268.329. Training.
[INFO] gewu. Step: 2060000. Time Elapsed: 1274.649 s. Mean Reward: 606.132. Std of Reward: 233.345. Training.
[INFO] gewu. Step: 2080000. Time Elapsed: 1285.343 s. Mean Reward: 565.026. Std of Reward: 230.037. Training.
[INFO] gewu. Step: 2100000. Time Elapsed: 1295.948 s. Mean Reward: 605.076. Std of Reward: 208.667. Training.
[INFO] gewu. Step: 2120000. Time Elapsed: 1306.497 s. Mean Reward: 651.600. Std of Reward: 167.145. Training.
[INFO] gewu. Step: 2140000. Time Elapsed: 1318.717 s. Mean Reward: 664.085. Std of Reward: 168.315. Training.
[INFO] gewu. Step: 2160000. Time Elapsed: 1332.072 s. Mean Reward: 697.060. Std of Reward: 125.800. Training.
[INFO] gewu. Step: 2180000. Time Elapsed: 1345.649 s. Mean Reward: 601.171. Std of Reward: 236.940. Training.
[INFO] gewu. Step: 2200000. Time Elapsed: 1359.459 s. Mean Reward: 719.659. Std of Reward: 50.866. Training.
[INFO] gewu. Step: 2220000. Time Elapsed: 1372.988 s. Mean Reward: 711.382. Std of Reward: 106.471. Training.
[INFO] gewu. Step: 2240000. Time Elapsed: 1386.835 s. Mean Reward: 638.338. Std of Reward: 163.099. Training.
[INFO] gewu. Step: 2260000. Time Elapsed: 1399.588 s. Mean Reward: 672.670. Std of Reward: 146.105. Training.
[INFO] gewu. Step: 2280000. Time Elapsed: 1413.137 s. Mean Reward: 659.064. Std of Reward: 162.821. Training.
[INFO] gewu. Step: 2300000. Time Elapsed: 1426.929 s. Mean Reward: 661.475. Std of Reward: 217.100. Training.
[INFO] gewu. Step: 2320000. Time Elapsed: 1434.737 s. Mean Reward: 587.094. Std of Reward: 199.945. Training.
[INFO] gewu. Step: 2340000. Time Elapsed: 1446.402 s. Mean Reward: 692.773. Std of Reward: 87.481. Training.
[INFO] gewu. Step: 2360000. Time Elapsed: 1457.064 s. Mean Reward: 650.988. Std of Reward: 173.409. Training.
[INFO] gewu. Step: 2380000. Time Elapsed: 1467.917 s. Mean Reward: 642.133. Std of Reward: 202.208. Training.
[INFO] gewu. Step: 2400000. Time Elapsed: 1478.561 s. Mean Reward: 658.993. Std of Reward: 185.790. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-2399442.onnx
[INFO] gewu. Step: 2420000. Time Elapsed: 1490.122 s. Mean Reward: 666.734. Std of Reward: 167.239. Training.
[INFO] gewu. Step: 2440000. Time Elapsed: 1500.106 s. Mean Reward: 688.046. Std of Reward: 102.397. Training.
[INFO] gewu. Step: 2460000. Time Elapsed: 1510.784 s. Mean Reward: 688.164. Std of Reward: 140.365. Training.
[INFO] gewu. Step: 2480000. Time Elapsed: 1521.460 s. Mean Reward: 728.767. Std of Reward: 19.097. Training.
[INFO] gewu. Step: 2500000. Time Elapsed: 1532.355 s. Mean Reward: 665.869. Std of Reward: 186.812. Training.
[INFO] gewu. Step: 2520000. Time Elapsed: 1542.973 s. Mean Reward: 712.990. Std of Reward: 135.911. Training.
[INFO] gewu. Step: 2540000. Time Elapsed: 1553.836 s. Mean Reward: 668.470. Std of Reward: 150.156. Training.
[INFO] gewu. Step: 2560000. Time Elapsed: 1565.217 s. Mean Reward: 714.805. Std of Reward: 35.483. Training.
[INFO] gewu. Step: 2580000. Time Elapsed: 1576.722 s. Mean Reward: 729.602. Std of Reward: 30.330. Training.
[INFO] gewu. Step: 2600000. Time Elapsed: 1591.047 s. Mean Reward: 729.760. Std of Reward: 18.841. Training.
[INFO] gewu. Step: 2620000. Time Elapsed: 1604.910 s. Mean Reward: 683.802. Std of Reward: 141.878. Training.
[INFO] gewu. Step: 2640000. Time Elapsed: 1620.467 s. Mean Reward: 659.550. Std of Reward: 136.072. Training.
[INFO] gewu. Step: 2660000. Time Elapsed: 1633.496 s. Mean Reward: 733.993. Std of Reward: 96.801. Training.
[INFO] gewu. Step: 2680000. Time Elapsed: 1648.156 s. Mean Reward: 651.472. Std of Reward: 188.033. Training.
[INFO] gewu. Step: 2700000. Time Elapsed: 1662.598 s. Mean Reward: 679.816. Std of Reward: 167.375. Training.
[INFO] gewu. Step: 2720000. Time Elapsed: 1677.135 s. Mean Reward: 627.236. Std of Reward: 240.581. Training.
[INFO] gewu. Step: 2740000. Time Elapsed: 1692.086 s. Mean Reward: 747.942. Std of Reward: 15.862. Training.
[INFO] gewu. Step: 2760000. Time Elapsed: 1706.242 s. Mean Reward: 752.173. Std of Reward: 21.333. Training.
[INFO] gewu. Step: 2780000. Time Elapsed: 1719.991 s. Mean Reward: 756.044. Std of Reward: 14.643. Training.
[INFO] gewu. Step: 2800000. Time Elapsed: 1734.723 s. Mean Reward: 752.402. Std of Reward: 42.004. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-2799829.onnx
[INFO] gewu. Step: 2820000. Time Elapsed: 1741.563 s. Mean Reward: 738.593. Std of Reward: 59.486. Training.
[INFO] gewu. Step: 2840000. Time Elapsed: 1752.546 s. Mean Reward: 761.370. Std of Reward: 16.358. Training.
[INFO] gewu. Step: 2860000. Time Elapsed: 1763.519 s. Mean Reward: 757.223. Std of Reward: 9.928. Training.
[INFO] gewu. Step: 2880000. Time Elapsed: 1774.290 s. Mean Reward: 724.090. Std of Reward: 127.168. Training.
[INFO] gewu. Step: 2900000. Time Elapsed: 1785.196 s. Mean Reward: 735.381. Std of Reward: 70.749. Training.
[INFO] gewu. Step: 2920000. Time Elapsed: 1796.303 s. Mean Reward: 747.500. Std of Reward: 15.094. Training.
[INFO] gewu. Step: 2940000. Time Elapsed: 1807.300 s. Mean Reward: 749.177. Std of Reward: 15.425. Training.
[INFO] gewu. Step: 2960000. Time Elapsed: 1818.180 s. Mean Reward: 743.508. Std of Reward: 19.179. Training.
[INFO] gewu. Step: 2980000. Time Elapsed: 1830.237 s. Mean Reward: 746.080. Std of Reward: 21.743. Training.
[INFO] gewu. Step: 3000000. Time Elapsed: 1843.884 s. Mean Reward: 719.341. Std of Reward: 125.051. Training.
[INFO] gewu. Step: 3020000. Time Elapsed: 1855.411 s. Mean Reward: 700.996. Std of Reward: 136.170. Training.
[INFO] gewu. Step: 3040000. Time Elapsed: 1866.537 s. Mean Reward: 714.284. Std of Reward: 124.972. Training.
[INFO] gewu. Step: 3060000. Time Elapsed: 1877.377 s. Mean Reward: 710.697. Std of Reward: 164.411. Training.
[INFO] gewu. Step: 3080000. Time Elapsed: 1888.027 s. Mean Reward: 674.378. Std of Reward: 216.062. Training.
[INFO] gewu. Step: 3100000. Time Elapsed: 1899.200 s. Mean Reward: 725.305. Std of Reward: 96.099. Training.
[INFO] gewu. Step: 3120000. Time Elapsed: 1910.353 s. Mean Reward: 680.081. Std of Reward: 203.408. Training.
[INFO] gewu. Step: 3140000. Time Elapsed: 1921.554 s. Mean Reward: 722.288. Std of Reward: 127.340. Training.
[INFO] gewu. Step: 3160000. Time Elapsed: 1932.098 s. Mean Reward: 653.586. Std of Reward: 196.612. Training.
[INFO] gewu. Step: 3180000. Time Elapsed: 1942.974 s. Mean Reward: 710.303. Std of Reward: 124.145. Training.
[INFO] gewu. Step: 3200000. Time Elapsed: 1953.911 s. Mean Reward: 679.643. Std of Reward: 163.201. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-3199511.onnx
[INFO] gewu. Step: 3220000. Time Elapsed: 1964.759 s. Mean Reward: 723.359. Std of Reward: 53.986. Training.
[INFO] gewu. Step: 3240000. Time Elapsed: 1975.879 s. Mean Reward: 704.591. Std of Reward: 91.524. Training.
[INFO] gewu. Step: 3260000. Time Elapsed: 1982.640 s. Mean Reward: 698.947. Std of Reward: 137.269. Training.
[INFO] gewu. Step: 3280000. Time Elapsed: 1993.699 s. Mean Reward: 752.643. Std of Reward: 18.972. Training.
[INFO] gewu. Step: 3300000. Time Elapsed: 2004.325 s. Mean Reward: 742.945. Std of Reward: 87.887. Training.
[INFO] gewu. Step: 3320000. Time Elapsed: 2015.086 s. Mean Reward: 705.874. Std of Reward: 143.303. Training.
[INFO] gewu. Step: 3340000. Time Elapsed: 2025.875 s. Mean Reward: 724.879. Std of Reward: 142.482. Training.
[INFO] gewu. Step: 3360000. Time Elapsed: 2036.919 s. Mean Reward: 715.834. Std of Reward: 156.656. Training.
[INFO] gewu. Step: 3380000. Time Elapsed: 2047.955 s. Mean Reward: 727.639. Std of Reward: 94.305. Training.
[INFO] gewu. Step: 3400000. Time Elapsed: 2058.920 s. Mean Reward: 712.781. Std of Reward: 138.796. Training.
[INFO] gewu. Step: 3420000. Time Elapsed: 2069.694 s. Mean Reward: 768.032. Std of Reward: 11.800. Training.
[INFO] gewu. Step: 3440000. Time Elapsed: 2080.857 s. Mean Reward: 739.781. Std of Reward: 113.230. Training.
[INFO] gewu. Step: 3460000. Time Elapsed: 2091.695 s. Mean Reward: 765.454. Std of Reward: 14.380. Training.
[INFO] gewu. Step: 3480000. Time Elapsed: 2102.116 s. Mean Reward: 734.463. Std of Reward: 133.788. Training.
[INFO] gewu. Step: 3500000. Time Elapsed: 2112.854 s. Mean Reward: 738.171. Std of Reward: 124.368. Training.
[INFO] gewu. Step: 3520000. Time Elapsed: 2123.863 s. Mean Reward: 766.790. Std of Reward: 12.399. Training.
[INFO] gewu. Step: 3540000. Time Elapsed: 2135.047 s. Mean Reward: 731.197. Std of Reward: 113.846. Training.
[INFO] gewu. Step: 3560000. Time Elapsed: 2145.751 s. Mean Reward: 766.917. Std of Reward: 13.347. Training.
[INFO] gewu. Step: 3580000. Time Elapsed: 2156.645 s. Mean Reward: 759.949. Std of Reward: 16.990. Training.
[INFO] gewu. Step: 3600000. Time Elapsed: 2167.770 s. Mean Reward: 721.839. Std of Reward: 173.406. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-3599786.onnx
[INFO] gewu. Step: 3620000. Time Elapsed: 2178.690 s. Mean Reward: 735.482. Std of Reward: 51.836. Training.
[INFO] gewu. Step: 3640000. Time Elapsed: 2189.551 s. Mean Reward: 705.992. Std of Reward: 191.021. Training.
[INFO] gewu. Step: 3660000. Time Elapsed: 2196.370 s. Mean Reward: 755.827. Std of Reward: 14.252. Training.
[INFO] gewu. Step: 3680000. Time Elapsed: 2207.294 s. Mean Reward: 729.258. Std of Reward: 116.911. Training.
[INFO] gewu. Step: 3700000. Time Elapsed: 2218.173 s. Mean Reward: 755.670. Std of Reward: 9.093. Training.
[INFO] gewu. Step: 3720000. Time Elapsed: 2228.898 s. Mean Reward: 753.086. Std of Reward: 17.376. Training.
[INFO] gewu. Step: 3740000. Time Elapsed: 2238.575 s. Mean Reward: 714.048. Std of Reward: 116.047. Training.
[INFO] gewu. Step: 3760000. Time Elapsed: 2249.342 s. Mean Reward: 759.699. Std of Reward: 14.430. Training.
[INFO] gewu. Step: 3780000. Time Elapsed: 2260.359 s. Mean Reward: 760.657. Std of Reward: 14.241. Training.
[INFO] gewu. Step: 3800000. Time Elapsed: 2270.436 s. Mean Reward: 725.038. Std of Reward: 121.307. Training.
[INFO] gewu. Step: 3820000. Time Elapsed: 2281.641 s. Mean Reward: 749.051. Std of Reward: 41.529. Training.
[INFO] gewu. Step: 3840000. Time Elapsed: 2292.332 s. Mean Reward: 760.468. Std of Reward: 18.126. Training.
[INFO] gewu. Step: 3860000. Time Elapsed: 2303.346 s. Mean Reward: 717.891. Std of Reward: 193.629. Training.
[INFO] gewu. Step: 3880000. Time Elapsed: 2314.590 s. Mean Reward: 709.535. Std of Reward: 162.046. Training.
[INFO] gewu. Step: 3900000. Time Elapsed: 2325.896 s. Mean Reward: 701.745. Std of Reward: 210.100. Training.
[INFO] gewu. Step: 3920000. Time Elapsed: 2336.785 s. Mean Reward: 692.040. Std of Reward: 228.170. Training.
[INFO] gewu. Step: 3940000. Time Elapsed: 2347.498 s. Mean Reward: 747.877. Std of Reward: 86.632. Training.
[INFO] gewu. Step: 3960000. Time Elapsed: 2357.735 s. Mean Reward: 728.750. Std of Reward: 118.585. Training.
[INFO] gewu. Step: 3980000. Time Elapsed: 2368.917 s. Mean Reward: 690.064. Std of Reward: 205.558. Training.
[INFO] gewu. Step: 4000000. Time Elapsed: 2379.931 s. Mean Reward: 750.046. Std of Reward: 86.064. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-3999801.onnx
[INFO] gewu. Step: 4020000. Time Elapsed: 2391.028 s. Mean Reward: 713.797. Std of Reward: 140.025. Training.
[INFO] gewu. Step: 4040000. Time Elapsed: 2398.249 s. Mean Reward: 708.888. Std of Reward: 137.641. Training.
[INFO] gewu. Step: 4060000. Time Elapsed: 2411.732 s. Mean Reward: 675.331. Std of Reward: 194.477. Training.
[INFO] gewu. Step: 4080000. Time Elapsed: 2425.254 s. Mean Reward: 619.160. Std of Reward: 213.968. Training.
[INFO] gewu. Step: 4100000. Time Elapsed: 2438.730 s. Mean Reward: 724.161. Std of Reward: 135.856. Training.
[INFO] gewu. Step: 4120000. Time Elapsed: 2451.516 s. Mean Reward: 769.268. Std of Reward: 10.524. Training.
[INFO] gewu. Step: 4140000. Time Elapsed: 2464.478 s. Mean Reward: 736.480. Std of Reward: 121.724. Training.
[INFO] gewu. Step: 4160000. Time Elapsed: 2477.516 s. Mean Reward: 768.497. Std of Reward: 14.574. Training.
[INFO] gewu. Step: 4180000. Time Elapsed: 2490.539 s. Mean Reward: 706.449. Std of Reward: 152.414. Training.
[INFO] gewu. Step: 4200000. Time Elapsed: 2503.589 s. Mean Reward: 756.339. Std of Reward: 51.641. Training.
[INFO] gewu. Step: 4220000. Time Elapsed: 2516.587 s. Mean Reward: 710.645. Std of Reward: 156.848. Training.
[INFO] gewu. Step: 4240000. Time Elapsed: 2529.683 s. Mean Reward: 773.038. Std of Reward: 10.794. Training.
[INFO] gewu. Step: 4260000. Time Elapsed: 2542.154 s. Mean Reward: 686.425. Std of Reward: 219.105. Training.
[INFO] gewu. Step: 4280000. Time Elapsed: 2555.126 s. Mean Reward: 727.707. Std of Reward: 135.467. Training.
[INFO] gewu. Step: 4300000. Time Elapsed: 2567.994 s. Mean Reward: 757.870. Std of Reward: 76.393. Training.
[INFO] gewu. Step: 4320000. Time Elapsed: 2580.715 s. Mean Reward: 748.582. Std of Reward: 98.197. Training.
[INFO] gewu. Step: 4340000. Time Elapsed: 2593.939 s. Mean Reward: 736.106. Std of Reward: 114.383. Training.
[INFO] gewu. Step: 4360000. Time Elapsed: 2606.817 s. Mean Reward: 749.159. Std of Reward: 101.592. Training.
[INFO] gewu. Step: 4380000. Time Elapsed: 2620.546 s. Mean Reward: 697.793. Std of Reward: 227.578. Training.
[INFO] gewu. Step: 4400000. Time Elapsed: 2633.512 s. Mean Reward: 714.418. Std of Reward: 111.492. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-4399424.onnx
[INFO] gewu. Step: 4420000. Time Elapsed: 2645.888 s. Mean Reward: 689.320. Std of Reward: 203.298. Training.
[INFO] gewu. Step: 4440000. Time Elapsed: 2659.229 s. Mean Reward: 692.917. Std of Reward: 172.649. Training.
[INFO] gewu. Step: 4460000. Time Elapsed: 2672.371 s. Mean Reward: 698.344. Std of Reward: 206.826. Training.
[INFO] gewu. Step: 4480000. Time Elapsed: 2685.270 s. Mean Reward: 634.232. Std of Reward: 249.121. Training.
[INFO] gewu. Step: 4500000. Time Elapsed: 2698.235 s. Mean Reward: 760.246. Std of Reward: 67.709. Training.
[INFO] gewu. Step: 4520000. Time Elapsed: 2710.833 s. Mean Reward: 696.944. Std of Reward: 160.448. Training.
[INFO] gewu. Step: 4540000. Time Elapsed: 2723.346 s. Mean Reward: 759.057. Std of Reward: 88.482. Training.
[INFO] gewu. Step: 4560000. Time Elapsed: 2730.461 s. Mean Reward: 789.944. Std of Reward: 17.466. Training.
[INFO] gewu. Step: 4580000. Time Elapsed: 2743.808 s. Mean Reward: 757.587. Std of Reward: 106.762. Training.
[INFO] gewu. Step: 4600000. Time Elapsed: 2755.901 s. Mean Reward: 667.229. Std of Reward: 241.098. Training.
[INFO] gewu. Step: 4620000. Time Elapsed: 2769.892 s. Mean Reward: 681.042. Std of Reward: 199.610. Training.
[INFO] gewu. Step: 4640000. Time Elapsed: 2782.858 s. Mean Reward: 685.119. Std of Reward: 194.878. Training.
[INFO] gewu. Step: 4660000. Time Elapsed: 2794.943 s. Mean Reward: 726.069. Std of Reward: 131.802. Training.
[INFO] gewu. Step: 4680000. Time Elapsed: 2808.958 s. Mean Reward: 709.086. Std of Reward: 170.359. Training.
[INFO] gewu. Step: 4700000. Time Elapsed: 2821.565 s. Mean Reward: 751.599. Std of Reward: 129.134. Training.
[INFO] gewu. Step: 4720000. Time Elapsed: 2834.411 s. Mean Reward: 734.587. Std of Reward: 168.584. Training.
[INFO] gewu. Step: 4740000. Time Elapsed: 2847.299 s. Mean Reward: 748.461. Std of Reward: 120.359. Training.
[INFO] gewu. Step: 4760000. Time Elapsed: 2859.557 s. Mean Reward: 705.717. Std of Reward: 182.166. Training.
[INFO] gewu. Step: 4780000. Time Elapsed: 2871.807 s. Mean Reward: 732.163. Std of Reward: 143.951. Training.
[INFO] gewu. Step: 4800000. Time Elapsed: 2885.285 s. Mean Reward: 712.188. Std of Reward: 186.001. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-4799195.onnx
[INFO] gewu. Step: 4820000. Time Elapsed: 2898.557 s. Mean Reward: 716.185. Std of Reward: 134.077. Training.
[INFO] gewu. Step: 4840000. Time Elapsed: 2911.643 s. Mean Reward: 777.318. Std of Reward: 50.465. Training.
[INFO] gewu. Step: 4860000. Time Elapsed: 2924.488 s. Mean Reward: 747.765. Std of Reward: 141.592. Training.
[INFO] gewu. Step: 4880000. Time Elapsed: 2937.453 s. Mean Reward: 755.842. Std of Reward: 103.954. Training.
[INFO] gewu. Step: 4900000. Time Elapsed: 2950.007 s. Mean Reward: 735.068. Std of Reward: 149.680. Training.
[INFO] gewu. Step: 4920000. Time Elapsed: 2963.165 s. Mean Reward: 740.285. Std of Reward: 153.235. Training.
[INFO] gewu. Step: 4940000. Time Elapsed: 2975.704 s. Mean Reward: 727.578. Std of Reward: 176.728. Training.
[INFO] gewu. Step: 4960000. Time Elapsed: 2988.785 s. Mean Reward: 777.175. Std of Reward: 111.463. Training.
[INFO] gewu. Step: 4980000. Time Elapsed: 3001.368 s. Mean Reward: 672.969. Std of Reward: 239.751. Training.
[INFO] gewu. Step: 5000000. Time Elapsed: 3008.506 s. Mean Reward: 742.086. Std of Reward: 126.828. Training.
[INFO] gewu. Step: 5020000. Time Elapsed: 3021.188 s. Mean Reward: 744.144. Std of Reward: 139.845. Training.
[INFO] gewu. Step: 5040000. Time Elapsed: 3034.413 s. Mean Reward: 733.607. Std of Reward: 216.882. Training.
[INFO] gewu. Step: 5060000. Time Elapsed: 3047.117 s. Mean Reward: 699.118. Std of Reward: 208.221. Training.
[INFO] gewu. Step: 5080000. Time Elapsed: 3059.876 s. Mean Reward: 801.508. Std of Reward: 14.941. Training.
[INFO] gewu. Step: 5100000. Time Elapsed: 3072.568 s. Mean Reward: 780.497. Std of Reward: 75.283. Training.
[INFO] gewu. Step: 5120000. Time Elapsed: 3085.225 s. Mean Reward: 767.983. Std of Reward: 119.916. Training.
[INFO] gewu. Step: 5140000. Time Elapsed: 3098.115 s. Mean Reward: 789.965. Std of Reward: 93.658. Training.
[INFO] gewu. Step: 5160000. Time Elapsed: 3110.834 s. Mean Reward: 770.901. Std of Reward: 114.998. Training.
[INFO] gewu. Step: 5180000. Time Elapsed: 3122.765 s. Mean Reward: 772.399. Std of Reward: 122.542. Training.
[INFO] gewu. Step: 5200000. Time Elapsed: 3136.571 s. Mean Reward: 732.942. Std of Reward: 146.873. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-5199846.onnx
[INFO] gewu. Step: 5220000. Time Elapsed: 3149.016 s. Mean Reward: 760.229. Std of Reward: 129.866. Training.
[INFO] gewu. Step: 5240000. Time Elapsed: 3161.745 s. Mean Reward: 799.170. Std of Reward: 110.847. Training.
[INFO] gewu. Step: 5260000. Time Elapsed: 3173.783 s. Mean Reward: 788.455. Std of Reward: 112.769. Training.
[INFO] gewu. Step: 5280000. Time Elapsed: 3186.426 s. Mean Reward: 752.274. Std of Reward: 212.102. Training.
[INFO] gewu. Step: 5300000. Time Elapsed: 3198.993 s. Mean Reward: 778.544. Std of Reward: 164.391. Training.
[INFO] gewu. Step: 5320000. Time Elapsed: 3211.813 s. Mean Reward: 738.730. Std of Reward: 172.076. Training.
[INFO] gewu. Step: 5340000. Time Elapsed: 3224.799 s. Mean Reward: 710.889. Std of Reward: 205.479. Training.
[INFO] gewu. Step: 5360000. Time Elapsed: 3238.247 s. Mean Reward: 717.270. Std of Reward: 272.556. Training.
[INFO] gewu. Step: 5380000. Time Elapsed: 3250.351 s. Mean Reward: 779.411. Std of Reward: 135.708. Training.
[INFO] gewu. Step: 5400000. Time Elapsed: 3263.313 s. Mean Reward: 760.783. Std of Reward: 183.332. Training.
[INFO] gewu. Step: 5420000. Time Elapsed: 3269.525 s. Mean Reward: 735.672. Std of Reward: 223.891. Training.
[INFO] gewu. Step: 5440000. Time Elapsed: 3283.176 s. Mean Reward: 786.680. Std of Reward: 207.476. Training.
[INFO] gewu. Step: 5460000. Time Elapsed: 3295.944 s. Mean Reward: 793.348. Std of Reward: 206.253. Training.
[INFO] gewu. Step: 5480000. Time Elapsed: 3308.057 s. Mean Reward: 761.569. Std of Reward: 212.995. Training.
[INFO] gewu. Step: 5500000. Time Elapsed: 3320.873 s. Mean Reward: 769.923. Std of Reward: 202.734. Training.
[INFO] gewu. Step: 5520000. Time Elapsed: 3334.652 s. Mean Reward: 682.240. Std of Reward: 324.388. Training.
[INFO] gewu. Step: 5540000. Time Elapsed: 3347.811 s. Mean Reward: 761.692. Std of Reward: 344.617. Training.
[INFO] gewu. Step: 5560000. Time Elapsed: 3360.629 s. Mean Reward: 848.170. Std of Reward: 117.388. Training.
[INFO] gewu. Step: 5580000. Time Elapsed: 3372.851 s. Mean Reward: 846.577. Std of Reward: 147.042. Training.
[INFO] gewu. Step: 5600000. Time Elapsed: 3385.617 s. Mean Reward: 801.953. Std of Reward: 225.527. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-5599809.onnx
[INFO] gewu. Step: 5620000. Time Elapsed: 3398.326 s. Mean Reward: 819.216. Std of Reward: 216.950. Training.
[INFO] gewu. Step: 5640000. Time Elapsed: 3410.952 s. Mean Reward: 901.998. Std of Reward: 28.330. Training.
[INFO] gewu. Step: 5660000. Time Elapsed: 3423.561 s. Mean Reward: 834.850. Std of Reward: 184.079. Training.
[INFO] gewu. Step: 5680000. Time Elapsed: 3436.093 s. Mean Reward: 882.432. Std of Reward: 93.459. Training.
[INFO] gewu. Step: 5700000. Time Elapsed: 3448.756 s. Mean Reward: 906.512. Std of Reward: 68.166. Training.
[INFO] gewu. Step: 5720000. Time Elapsed: 3461.426 s. Mean Reward: 866.661. Std of Reward: 160.160. Training.
[INFO] gewu. Step: 5740000. Time Elapsed: 3474.163 s. Mean Reward: 815.171. Std of Reward: 195.325. Training.
[INFO] gewu. Step: 5760000. Time Elapsed: 3487.047 s. Mean Reward: 800.763. Std of Reward: 252.709. Training.
[INFO] gewu. Step: 5780000. Time Elapsed: 3499.429 s. Mean Reward: 807.857. Std of Reward: 207.036. Training.
[INFO] gewu. Step: 5800000. Time Elapsed: 3512.052 s. Mean Reward: 842.594. Std of Reward: 193.119. Training.
[INFO] gewu. Step: 5820000. Time Elapsed: 3524.015 s. Mean Reward: 860.055. Std of Reward: 198.593. Training.
[INFO] gewu. Step: 5840000. Time Elapsed: 3536.219 s. Mean Reward: 859.855. Std of Reward: 226.569. Training.
[INFO] gewu. Step: 5860000. Time Elapsed: 3543.447 s. Mean Reward: 805.449. Std of Reward: 285.660. Training.
[INFO] gewu. Step: 5880000. Time Elapsed: 3555.831 s. Mean Reward: 945.141. Std of Reward: 31.355. Training.
[INFO] gewu. Step: 5900000. Time Elapsed: 3568.285 s. Mean Reward: 905.738. Std of Reward: 141.538. Training.
[INFO] gewu. Step: 5920000. Time Elapsed: 3581.064 s. Mean Reward: 925.965. Std of Reward: 84.544. Training.
[INFO] gewu. Step: 5940000. Time Elapsed: 3593.569 s. Mean Reward: 932.680. Std of Reward: 74.971. Training.
[INFO] gewu. Step: 5960000. Time Elapsed: 3606.221 s. Mean Reward: 898.941. Std of Reward: 150.739. Training.
[INFO] gewu. Step: 5980000. Time Elapsed: 3618.168 s. Mean Reward: 860.361. Std of Reward: 267.662. Training.
[INFO] gewu. Step: 6000000. Time Elapsed: 3631.477 s. Mean Reward: 914.637. Std of Reward: 149.710. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-5999875.onnx
[INFO] gewu. Step: 6020000. Time Elapsed: 3643.846 s. Mean Reward: 940.534. Std of Reward: 88.513. Training.
[INFO] gewu. Step: 6040000. Time Elapsed: 3656.125 s. Mean Reward: 945.112. Std of Reward: 92.498. Training.
[INFO] gewu. Step: 6060000. Time Elapsed: 3668.500 s. Mean Reward: 914.984. Std of Reward: 177.871. Training.
[INFO] gewu. Step: 6080000. Time Elapsed: 3681.223 s. Mean Reward: 946.906. Std of Reward: 172.432. Training.
[INFO] gewu. Step: 6100000. Time Elapsed: 3693.946 s. Mean Reward: 968.294. Std of Reward: 80.341. Training.
[INFO] gewu. Step: 6120000. Time Elapsed: 3708.091 s. Mean Reward: 923.689. Std of Reward: 194.937. Training.
[INFO] gewu. Step: 6140000. Time Elapsed: 3720.699 s. Mean Reward: 1006.158. Std of Reward: 27.506. Training.
[INFO] gewu. Step: 6160000. Time Elapsed: 3733.371 s. Mean Reward: 973.792. Std of Reward: 161.325. Training.
[INFO] gewu. Step: 6180000. Time Elapsed: 3745.761 s. Mean Reward: 978.188. Std of Reward: 112.055. Training.
[INFO] gewu. Step: 6200000. Time Elapsed: 3758.332 s. Mean Reward: 881.959. Std of Reward: 287.353. Training.
[INFO] gewu. Step: 6220000. Time Elapsed: 3770.985 s. Mean Reward: 998.693. Std of Reward: 21.098. Training.
[INFO] gewu. Step: 6240000. Time Elapsed: 3783.857 s. Mean Reward: 1002.053. Std of Reward: 19.060. Training.
[INFO] gewu. Step: 6260000. Time Elapsed: 3796.529 s. Mean Reward: 980.481. Std of Reward: 95.267. Training.
[INFO] gewu. Step: 6280000. Time Elapsed: 3803.427 s. Mean Reward: 947.850. Std of Reward: 221.075. Training.
[INFO] gewu. Step: 6300000. Time Elapsed: 3816.012 s. Mean Reward: 989.666. Std of Reward: 140.054. Training.
[INFO] gewu. Step: 6320000. Time Elapsed: 3828.632 s. Mean Reward: 992.176. Std of Reward: 111.453. Training.
[INFO] gewu. Step: 6340000. Time Elapsed: 3841.267 s. Mean Reward: 963.182. Std of Reward: 132.579. Training.
[INFO] gewu. Step: 6360000. Time Elapsed: 3853.993 s. Mean Reward: 970.897. Std of Reward: 172.681. Training.
[INFO] gewu. Step: 6380000. Time Elapsed: 3866.192 s. Mean Reward: 1014.700. Std of Reward: 25.823. Training.
[INFO] gewu. Step: 6400000. Time Elapsed: 3879.311 s. Mean Reward: 944.845. Std of Reward: 206.373. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-6399629.onnx
[INFO] gewu. Step: 6420000. Time Elapsed: 3891.737 s. Mean Reward: 986.983. Std of Reward: 139.050. Training.
[INFO] gewu. Step: 6440000. Time Elapsed: 3904.492 s. Mean Reward: 982.745. Std of Reward: 136.191. Training.
[INFO] gewu. Step: 6460000. Time Elapsed: 3917.070 s. Mean Reward: 1024.943. Std of Reward: 19.232. Training.
[INFO] gewu. Step: 6480000. Time Elapsed: 3929.867 s. Mean Reward: 983.291. Std of Reward: 170.235. Training.
[INFO] gewu. Step: 6500000. Time Elapsed: 3942.216 s. Mean Reward: 1006.763. Std of Reward: 26.044. Training.
[INFO] gewu. Step: 6520000. Time Elapsed: 3954.821 s. Mean Reward: 1027.240. Std of Reward: 23.512. Training.
[INFO] gewu. Step: 6540000. Time Elapsed: 3967.516 s. Mean Reward: 1007.709. Std of Reward: 90.591. Training.
[INFO] gewu. Step: 6560000. Time Elapsed: 3980.230 s. Mean Reward: 968.514. Std of Reward: 189.663. Training.
[INFO] gewu. Step: 6580000. Time Elapsed: 3992.738 s. Mean Reward: 1033.789. Std of Reward: 40.883. Training.
[INFO] gewu. Step: 6600000. Time Elapsed: 4005.596 s. Mean Reward: 988.391. Std of Reward: 159.766. Training.
[INFO] gewu. Step: 6620000. Time Elapsed: 4018.516 s. Mean Reward: 985.727. Std of Reward: 218.069. Training.
[INFO] gewu. Step: 6640000. Time Elapsed: 4030.849 s. Mean Reward: 888.138. Std of Reward: 382.290. Training.
[INFO] gewu. Step: 6660000. Time Elapsed: 4043.543 s. Mean Reward: 1052.586. Std of Reward: 27.485. Training.
[INFO] gewu. Step: 6680000. Time Elapsed: 4056.094 s. Mean Reward: 1011.095. Std of Reward: 112.136. Training.
[INFO] gewu. Step: 6700000. Time Elapsed: 4068.472 s. Mean Reward: 1009.131. Std of Reward: 143.809. Training.
[INFO] gewu. Step: 6720000. Time Elapsed: 4081.272 s. Mean Reward: 985.744. Std of Reward: 161.545. Training.
[INFO] gewu. Step: 6740000. Time Elapsed: 4088.235 s. Mean Reward: 1051.799. Std of Reward: 31.510. Training.
[INFO] gewu. Step: 6760000. Time Elapsed: 4100.746 s. Mean Reward: 1059.995. Std of Reward: 29.381. Training.
[INFO] gewu. Step: 6780000. Time Elapsed: 4113.244 s. Mean Reward: 1018.755. Std of Reward: 190.876. Training.
[INFO] gewu. Step: 6800000. Time Elapsed: 4126.035 s. Mean Reward: 986.736. Std of Reward: 176.936. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-6799333.onnx
[INFO] gewu. Step: 6820000. Time Elapsed: 4138.464 s. Mean Reward: 1012.152. Std of Reward: 179.803. Training.
[INFO] gewu. Step: 6840000. Time Elapsed: 4151.001 s. Mean Reward: 1065.434. Std of Reward: 50.082. Training.
[INFO] gewu. Step: 6860000. Time Elapsed: 4163.475 s. Mean Reward: 1047.061. Std of Reward: 123.359. Training.
[INFO] gewu. Step: 6880000. Time Elapsed: 4176.226 s. Mean Reward: 1012.973. Std of Reward: 201.216. Training.
[INFO] gewu. Step: 6900000. Time Elapsed: 4189.115 s. Mean Reward: 1066.863. Std of Reward: 19.465. Training.
[INFO] gewu. Step: 6920000. Time Elapsed: 4201.694 s. Mean Reward: 1078.273. Std of Reward: 32.934. Training.
[INFO] gewu. Step: 6940000. Time Elapsed: 4214.417 s. Mean Reward: 1072.353. Std of Reward: 26.803. Training.
[INFO] gewu. Step: 6960000. Time Elapsed: 4227.108 s. Mean Reward: 1048.629. Std of Reward: 160.069. Training.
[INFO] gewu. Step: 6980000. Time Elapsed: 4238.786 s. Mean Reward: 1039.609. Std of Reward: 119.125. Training.
[INFO] gewu. Step: 7000000. Time Elapsed: 4249.267 s. Mean Reward: 1038.240. Std of Reward: 161.600. Training.
[INFO] gewu. Step: 7020000. Time Elapsed: 4259.640 s. Mean Reward: 1075.310. Std of Reward: 100.315. Training.
[INFO] gewu. Step: 7040000. Time Elapsed: 4270.514 s. Mean Reward: 1102.057. Std of Reward: 24.373. Training.
[INFO] gewu. Step: 7060000. Time Elapsed: 4281.319 s. Mean Reward: 1051.016. Std of Reward: 138.181. Training.
[INFO] gewu. Step: 7080000. Time Elapsed: 4291.999 s. Mean Reward: 1100.003. Std of Reward: 33.183. Training.
[INFO] gewu. Step: 7100000. Time Elapsed: 4302.646 s. Mean Reward: 1060.910. Std of Reward: 151.584. Training.
[INFO] gewu. Step: 7120000. Time Elapsed: 4313.319 s. Mean Reward: 1107.783. Std of Reward: 30.699. Training.
[INFO] gewu. Step: 7140000. Time Elapsed: 4324.064 s. Mean Reward: 1038.034. Std of Reward: 205.935. Training.
[INFO] gewu. Step: 7160000. Time Elapsed: 4330.699 s. Mean Reward: 1070.839. Std of Reward: 146.094. Training.
[INFO] gewu. Step: 7180000. Time Elapsed: 4341.161 s. Mean Reward: 978.827. Std of Reward: 293.226. Training.
[INFO] gewu. Step: 7200000. Time Elapsed: 4351.585 s. Mean Reward: 1121.027. Std of Reward: 46.995. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-7199690.onnx
[INFO] gewu. Step: 7220000. Time Elapsed: 4362.134 s. Mean Reward: 1091.210. Std of Reward: 116.398. Training.
[INFO] gewu. Step: 7240000. Time Elapsed: 4372.562 s. Mean Reward: 1132.653. Std of Reward: 26.244. Training.
[INFO] gewu. Step: 7260000. Time Elapsed: 4382.991 s. Mean Reward: 1123.575. Std of Reward: 43.254. Training.
[INFO] gewu. Step: 7280000. Time Elapsed: 4393.260 s. Mean Reward: 1112.814. Std of Reward: 50.591. Training.
[INFO] gewu. Step: 7300000. Time Elapsed: 4403.713 s. Mean Reward: 1073.150. Std of Reward: 147.320. Training.
[INFO] gewu. Step: 7320000. Time Elapsed: 4414.055 s. Mean Reward: 1096.820. Std of Reward: 147.418. Training.
[INFO] gewu. Step: 7340000. Time Elapsed: 4424.524 s. Mean Reward: 1124.602. Std of Reward: 64.768. Training.
[INFO] gewu. Step: 7360000. Time Elapsed: 4435.095 s. Mean Reward: 1140.690. Std of Reward: 33.741. Training.
[INFO] gewu. Step: 7380000. Time Elapsed: 4445.616 s. Mean Reward: 1106.422. Std of Reward: 147.225. Training.
[INFO] gewu. Step: 7400000. Time Elapsed: 4456.119 s. Mean Reward: 1118.330. Std of Reward: 60.010. Training.
[INFO] gewu. Step: 7420000. Time Elapsed: 4466.645 s. Mean Reward: 1132.660. Std of Reward: 26.652. Training.
[INFO] gewu. Step: 7440000. Time Elapsed: 4477.358 s. Mean Reward: 1125.357. Std of Reward: 124.628. Training.
[INFO] gewu. Step: 7460000. Time Elapsed: 4488.212 s. Mean Reward: 1171.144. Std of Reward: 31.720. Training.
[INFO] gewu. Step: 7480000. Time Elapsed: 4499.041 s. Mean Reward: 1070.677. Std of Reward: 247.217. Training.
[INFO] gewu. Step: 7500000. Time Elapsed: 4509.351 s. Mean Reward: 1149.221. Std of Reward: 39.677. Training.
[INFO] gewu. Step: 7520000. Time Elapsed: 4519.819 s. Mean Reward: 1127.704. Std of Reward: 121.092. Training.
[INFO] gewu. Step: 7540000. Time Elapsed: 4530.611 s. Mean Reward: 1128.955. Std of Reward: 187.583. Training.
[INFO] gewu. Step: 7560000. Time Elapsed: 4540.973 s. Mean Reward: 1170.664. Std of Reward: 34.318. Training.
[INFO] gewu. Step: 7580000. Time Elapsed: 4547.398 s. Mean Reward: 1143.128. Std of Reward: 178.133. Training.
[INFO] gewu. Step: 7600000. Time Elapsed: 4557.834 s. Mean Reward: 1163.050. Std of Reward: 38.557. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-7599604.onnx
[INFO] gewu. Step: 7620000. Time Elapsed: 4568.456 s. Mean Reward: 1097.220. Std of Reward: 231.796. Training.
[INFO] gewu. Step: 7640000. Time Elapsed: 4579.519 s. Mean Reward: 1112.896. Std of Reward: 172.811. Training.
[INFO] gewu. Step: 7660000. Time Elapsed: 4589.628 s. Mean Reward: 1131.993. Std of Reward: 130.524. Training.
[INFO] gewu. Step: 7680000. Time Elapsed: 4600.593 s. Mean Reward: 1133.161. Std of Reward: 151.392. Training.
[INFO] gewu. Step: 7700000. Time Elapsed: 4610.836 s. Mean Reward: 1183.843. Std of Reward: 36.026. Training.
[INFO] gewu. Step: 7720000. Time Elapsed: 4620.991 s. Mean Reward: 1150.594. Std of Reward: 149.585. Training.
[INFO] gewu. Step: 7740000. Time Elapsed: 4630.926 s. Mean Reward: 1159.573. Std of Reward: 80.252. Training.
[INFO] gewu. Step: 7760000. Time Elapsed: 4641.505 s. Mean Reward: 1169.790. Std of Reward: 100.656. Training.
[INFO] gewu. Step: 7780000. Time Elapsed: 4651.946 s. Mean Reward: 1202.292. Std of Reward: 20.724. Training.
[INFO] gewu. Step: 7800000. Time Elapsed: 4662.174 s. Mean Reward: 1144.259. Std of Reward: 154.016. Training.
[INFO] gewu. Step: 7820000. Time Elapsed: 4673.065 s. Mean Reward: 1174.561. Std of Reward: 127.855. Training.
[INFO] gewu. Step: 7840000. Time Elapsed: 4684.214 s. Mean Reward: 1173.309. Std of Reward: 74.948. Training.
[INFO] gewu. Step: 7860000. Time Elapsed: 4696.359 s. Mean Reward: 1174.989. Std of Reward: 153.174. Training.
[INFO] gewu. Step: 7880000. Time Elapsed: 4707.718 s. Mean Reward: 1087.177. Std of Reward: 292.617. Training.
[INFO] gewu. Step: 7900000. Time Elapsed: 4718.630 s. Mean Reward: 1193.456. Std of Reward: 42.628. Training.
[INFO] gewu. Step: 7920000. Time Elapsed: 4729.698 s. Mean Reward: 1159.180. Std of Reward: 192.924. Training.
[INFO] gewu. Step: 7940000. Time Elapsed: 4740.615 s. Mean Reward: 1208.371. Std of Reward: 50.461. Training.
[INFO] gewu. Step: 7960000. Time Elapsed: 4751.548 s. Mean Reward: 1211.604. Std of Reward: 33.233. Training.
[INFO] gewu. Step: 7980000. Time Elapsed: 4762.194 s. Mean Reward: 1195.292. Std of Reward: 103.353. Training.
[INFO] gewu. Step: 8000000. Time Elapsed: 4768.677 s. Mean Reward: 1172.950. Std of Reward: 152.221. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-7999616.onnx
[INFO] gewu. Step: 8020000. Time Elapsed: 4779.102 s. Mean Reward: 1201.987. Std of Reward: 94.558. Training.
[INFO] gewu. Step: 8040000. Time Elapsed: 4789.660 s. Mean Reward: 1202.228. Std of Reward: 143.254. Training.
[INFO] gewu. Step: 8060000. Time Elapsed: 4799.721 s. Mean Reward: 1181.456. Std of Reward: 111.767. Training.
[INFO] gewu. Step: 8080000. Time Elapsed: 4810.137 s. Mean Reward: 1162.040. Std of Reward: 240.955. Training.
[INFO] gewu. Step: 8100000. Time Elapsed: 4820.426 s. Mean Reward: 1215.381. Std of Reward: 131.265. Training.
[INFO] gewu. Step: 8120000. Time Elapsed: 4831.219 s. Mean Reward: 1209.593. Std of Reward: 116.552. Training.
[INFO] gewu. Step: 8140000. Time Elapsed: 4841.693 s. Mean Reward: 1239.190. Std of Reward: 45.454. Training.
[INFO] gewu. Step: 8160000. Time Elapsed: 4852.707 s. Mean Reward: 1186.088. Std of Reward: 169.741. Training.
[INFO] gewu. Step: 8180000. Time Elapsed: 4863.074 s. Mean Reward: 1241.732. Std of Reward: 35.065. Training.
[INFO] gewu. Step: 8200000. Time Elapsed: 4874.072 s. Mean Reward: 1204.968. Std of Reward: 154.952. Training.
[INFO] gewu. Step: 8220000. Time Elapsed: 4885.493 s. Mean Reward: 1262.220. Std of Reward: 27.627. Training.
[INFO] gewu. Step: 8240000. Time Elapsed: 4896.356 s. Mean Reward: 1201.567. Std of Reward: 181.833. Training.
[INFO] gewu. Step: 8260000. Time Elapsed: 4907.732 s. Mean Reward: 1190.054. Std of Reward: 184.209. Training.
[INFO] gewu. Step: 8280000. Time Elapsed: 4920.426 s. Mean Reward: 1080.942. Std of Reward: 396.622. Training.
[INFO] gewu. Step: 8300000. Time Elapsed: 4930.934 s. Mean Reward: 1213.476. Std of Reward: 174.729. Training.
[INFO] gewu. Step: 8320000. Time Elapsed: 4941.929 s. Mean Reward: 1259.482. Std of Reward: 33.444. Training.
[INFO] gewu. Step: 8340000. Time Elapsed: 4953.349 s. Mean Reward: 1262.248. Std of Reward: 38.442. Training.
[INFO] gewu. Step: 8360000. Time Elapsed: 4965.830 s. Mean Reward: 1252.203. Std of Reward: 100.097. Training.
[INFO] gewu. Step: 8380000. Time Elapsed: 4976.344 s. Mean Reward: 1231.948. Std of Reward: 112.947. Training.
[INFO] gewu. Step: 8400000. Time Elapsed: 4987.581 s. Mean Reward: 1267.201. Std of Reward: 25.981. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-8399428.onnx
[INFO] gewu. Step: 8420000. Time Elapsed: 4998.626 s. Mean Reward: 1202.036. Std of Reward: 246.815. Training.
[INFO] gewu. Step: 8440000. Time Elapsed: 5009.986 s. Mean Reward: 1276.914. Std of Reward: 58.277. Training.
[INFO] gewu. Step: 8460000. Time Elapsed: 5017.215 s. Mean Reward: 1288.509. Std of Reward: 30.063. Training.
[INFO] gewu. Step: 8480000. Time Elapsed: 5028.077 s. Mean Reward: 1247.466. Std of Reward: 138.463. Training.
[INFO] gewu. Step: 8500000. Time Elapsed: 5039.260 s. Mean Reward: 1237.429. Std of Reward: 193.745. Training.
[INFO] gewu. Step: 8520000. Time Elapsed: 5051.252 s. Mean Reward: 1254.756. Std of Reward: 173.353. Training.
[INFO] gewu. Step: 8540000. Time Elapsed: 5062.816 s. Mean Reward: 1267.392. Std of Reward: 125.167. Training.
[INFO] gewu. Step: 8560000. Time Elapsed: 5074.073 s. Mean Reward: 1239.913. Std of Reward: 229.575. Training.
[INFO] gewu. Step: 8580000. Time Elapsed: 5086.115 s. Mean Reward: 1252.352. Std of Reward: 192.342. Training.
[INFO] gewu. Step: 8600000. Time Elapsed: 5097.520 s. Mean Reward: 1273.220. Std of Reward: 85.039. Training.
[INFO] gewu. Step: 8620000. Time Elapsed: 5108.658 s. Mean Reward: 1318.257. Std of Reward: 34.000. Training.
[INFO] gewu. Step: 8640000. Time Elapsed: 5119.882 s. Mean Reward: 1205.643. Std of Reward: 260.052. Training.
[INFO] gewu. Step: 8660000. Time Elapsed: 5131.148 s. Mean Reward: 1293.707. Std of Reward: 57.728. Training.
[INFO] gewu. Step: 8680000. Time Elapsed: 5142.583 s. Mean Reward: 1267.175. Std of Reward: 193.541. Training.
[INFO] gewu. Step: 8700000. Time Elapsed: 5153.698 s. Mean Reward: 1213.155. Std of Reward: 264.033. Training.
[INFO] gewu. Step: 8720000. Time Elapsed: 5164.956 s. Mean Reward: 1273.199. Std of Reward: 45.294. Training.
[INFO] gewu. Step: 8740000. Time Elapsed: 5176.157 s. Mean Reward: 1275.679. Std of Reward: 150.218. Training.
[INFO] gewu. Step: 8760000. Time Elapsed: 5187.510 s. Mean Reward: 1240.646. Std of Reward: 197.401. Training.
[INFO] gewu. Step: 8780000. Time Elapsed: 5198.737 s. Mean Reward: 1301.684. Std of Reward: 33.510. Training.
[INFO] gewu. Step: 8800000. Time Elapsed: 5209.937 s. Mean Reward: 1327.559. Std of Reward: 28.636. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-8799707.onnx
[INFO] gewu. Step: 8820000. Time Elapsed: 5220.993 s. Mean Reward: 1299.223. Std of Reward: 43.312. Training.
[INFO] gewu. Step: 8840000. Time Elapsed: 5231.903 s. Mean Reward: 1301.582. Std of Reward: 41.265. Training.
[INFO] gewu. Step: 8860000. Time Elapsed: 5238.562 s. Mean Reward: 1263.270. Std of Reward: 224.207. Training.
[INFO] gewu. Step: 8880000. Time Elapsed: 5249.133 s. Mean Reward: 1323.158. Std of Reward: 27.288. Training.
[INFO] gewu. Step: 8900000. Time Elapsed: 5260.103 s. Mean Reward: 1301.152. Std of Reward: 52.923. Training.
[INFO] gewu. Step: 8920000. Time Elapsed: 5271.327 s. Mean Reward: 1328.458. Std of Reward: 41.525. Training.
[INFO] Learning was interrupted. Please wait while the graph is generated.
[INFO] Exported results\ztest1.0\gewu\gewu-8923660.onnx
[INFO] Copied results\ztest1.0\gewu\gewu-8923660.onnx to results\ztest1.0\gewu.onnx.

(gewu) C:\Users\QunZ\Desktop\Unity-RL-Playground-main\Unity-RL-Playground-main\gewu\Assets\Playground>mlagents-learn config.yaml --run-id=ztest1.0 --resume
C:\Users\QunZ\miniconda3\envs\gewu\lib\site-packages\mlagents\torch_utils\torch.py:4: UserWarning: pkg_resources is deprecated as an API. See https://setuptools.pypa.io/en/latest/pkg_resources.html. The pkg_resources package is slated for removal as early as 2025-11-30. Refrain from using this package or pin to Setuptools<81.
  import pkg_resources

            ┐  ╖
        ╓╖╬│╡  ││╬╖╖
    ╓╖╬│││││┘  ╬│││││╬╖
 ╖╬│││││╬╜        ╙╬│││││╖╖                               ╗╗╗
 ╬╬╬╬╖││╦╖        ╖╬││╗╣╣╣╬      ╟╣╣╬    ╟╣╣╣             ╜╜╜  ╟╣╣
 ╬╬╬╬╬╬╬╬╖│╬╖╖╓╬╪│╓╣╣╣╣╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╒╣╣╖╗╣╣╣╗   ╣╣╣ ╣╣╣╣╣╣ ╟╣╣╖   ╣╣╣
 ╬╬╬╬┐  ╙╬╬╬╬│╓╣╣╣╝╜  ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╣╙ ╙╣╣╣  ╣╣╣ ╙╟╣╣╜╙  ╫╣╣  ╟╣╣
 ╬╬╬╬┐     ╙╬╬╣╣      ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣     ╣╣╣┌╣╣╜
 ╬╬╬╜       ╬╬╣╣      ╙╝╣╣╬      ╙╣╣╣╗╖╓╗╣╣╣╜ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣╦╓    ╣╣╣╣╣
 ╙   ╓╦╖    ╬╬╣╣   ╓╗╗╖            ╙╝╣╣╣╣╝╜   ╘╝╝╜   ╝╝╝  ╝╝╝   ╙╣╣╣    ╟╣╣╣
   ╩╬╬╬╬╬╬╦╦╬╬╣╣╗╣╣╣╣╣╣╣╝                                             ╫╣╣╣╣
      ╙╬╬╬╬╬╬╬╣╣╣╣╣╣╝╜
          ╙╬╬╬╣╣╣╜
             ╙

 Version information:
  ml-agents: 1.1.0,
  ml-agents-envs: 1.1.0,
  Communicator API: 1.5.0,
  PyTorch: 2.2.1+cpu
C:\Users\QunZ\miniconda3\envs\gewu\lib\site-packages\mlagents\torch_utils\torch.py:4: UserWarning: pkg_resources is deprecated as an API. See https://setuptools.pypa.io/en/latest/pkg_resources.html. The pkg_resources package is slated for removal as early as 2025-11-30. Refrain from using this package or pin to Setuptools<81.
  import pkg_resources
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 3.0.0 and communication version 1.5.0
[INFO] Connected new brain: gewu?team=0
[INFO] Hyperparameters for behavior name gewu:
        trainer_type:   ppo
        hyperparameters:
          batch_size:   2048
          buffer_size:  20480
          learning_rate:        0.0003
          beta: 0.005
          epsilon:      0.2
          lambd:        0.95
          num_epoch:    3
          shared_critic:        False
          learning_rate_schedule:       linear
          beta_schedule:        linear
          epsilon_schedule:     linear
        checkpoint_interval:    400000
        network_settings:
          normalize:    True
          hidden_units: 512
          num_layers:   3
          vis_encode_type:      simple
          memory:       None
          goal_conditioning_type:       hyper
          deterministic:        False
        reward_signals:
          extrinsic:
            gamma:      0.995
            strength:   1.0
            network_settings:
              normalize:        False
              hidden_units:     128
              num_layers:       2
              vis_encode_type:  simple
              memory:   None
              goal_conditioning_type:   hyper
              deterministic:    False
        init_path:      None
        keep_checkpoints:       5
        even_checkpoints:       False
        max_steps:      20000000
        time_horizon:   1000
        summary_freq:   20000
        threaded:       False
        self_play:      None
        behavioral_cloning:     None
[INFO] Resuming from results\ztest1.0\gewu.
[INFO] Resuming training from step 8923660.
[INFO] gewu. Step: 8940000. Time Elapsed: 13.886 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 8960000. Time Elapsed: 27.623 s. Mean Reward: 1933.315. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 8980000. Time Elapsed: 35.278 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 9000000. Time Elapsed: 53.768 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 9020000. Time Elapsed: 67.342 s. Mean Reward: 6799.005. Std of Reward: 352.663. Training.
[INFO] gewu. Step: 9040000. Time Elapsed: 74.776 s. Mean Reward: 6853.167. Std of Reward: 35.943. Training.
[INFO] gewu. Step: 9060000. Time Elapsed: 92.243 s. Mean Reward: 6969.277. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 9080000. Time Elapsed: 102.709 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 9100000. Time Elapsed: 113.101 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 9120000. Time Elapsed: 119.611 s. Mean Reward: 7280.069. Std of Reward: 75.030. Training.
[INFO] gewu. Step: 9140000. Time Elapsed: 133.614 s. Mean Reward: 7259.951. Std of Reward: 35.708. Training.
[INFO] gewu. Step: 9160000. Time Elapsed: 144.125 s. Mean Reward: 7564.449. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 9180000. Time Elapsed: 154.557 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 9200000. Time Elapsed: 165.058 s. Mean Reward: 5531.707. Std of Reward: 0.000. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-9199080.onnx
[INFO] gewu. Step: 9220000. Time Elapsed: 175.584 s. Mean Reward: 7667.285. Std of Reward: 91.259. Training.
[INFO] gewu. Step: 9240000. Time Elapsed: 182.511 s. Mean Reward: 7687.806. Std of Reward: 35.576. Training.
[INFO] gewu. Step: 9260000. Time Elapsed: 199.288 s. Mean Reward: 7756.780. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 9280000. Time Elapsed: 212.415 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 9300000. Time Elapsed: 223.340 s. Mean Reward: 7061.743. Std of Reward: 798.611. Training.
[INFO] gewu. Step: 9320000. Time Elapsed: 233.874 s. Mean Reward: 8004.603. Std of Reward: 44.871. Training.
[INFO] gewu. Step: 9340000. Time Elapsed: 245.249 s. Mean Reward: 4511.321. Std of Reward: 3606.991. Training.
[INFO] gewu. Step: 9360000. Time Elapsed: 255.875 s. Mean Reward: 4324.568. Std of Reward: 3340.112. Training.
[INFO] gewu. Step: 9380000. Time Elapsed: 262.523 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 9400000. Time Elapsed: 275.363 s. Mean Reward: 8135.579. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 9420000. Time Elapsed: 285.979 s. Mean Reward: 8254.636. Std of Reward: 50.240. Training.
[INFO] gewu. Step: 9440000. Time Elapsed: 296.510 s. Mean Reward: 8251.211. Std of Reward: 7.516. Training.
[INFO] gewu. Step: 9460000. Time Elapsed: 307.063 s. Mean Reward: 8331.047. Std of Reward: 22.749. Training.
[INFO] gewu. Step: 9480000. Time Elapsed: 317.543 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 9500000. Time Elapsed: 327.947 s. Mean Reward: 8492.319. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 9520000. Time Elapsed: 338.183 s. Mean Reward: 8551.509. Std of Reward: 47.751. Training.
[INFO] gewu. Step: 9540000. Time Elapsed: 348.794 s. Mean Reward: 8588.429. Std of Reward: 37.391. Training.
[INFO] gewu. Step: 9560000. Time Elapsed: 359.167 s. Mean Reward: 7247.954. Std of Reward: 2470.574. Training.
[INFO] gewu. Step: 9580000. Time Elapsed: 365.659 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 9600000. Time Elapsed: 377.984 s. Mean Reward: 8740.586. Std of Reward: 0.000. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-9599284.onnx
[INFO] gewu. Step: 9620000. Time Elapsed: 388.337 s. Mean Reward: 8852.071. Std of Reward: 33.114. Training.
[INFO] gewu. Step: 9640000. Time Elapsed: 399.743 s. Mean Reward: 3929.574. Std of Reward: 4088.117. Training.
[INFO] gewu. Step: 9660000. Time Elapsed: 410.343 s. Mean Reward: 8909.518. Std of Reward: 38.178. Training.
[INFO] gewu. Step: 9680000. Time Elapsed: 420.733 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 9700000. Time Elapsed: 431.058 s. Mean Reward: 9052.534. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 9720000. Time Elapsed: 441.476 s. Mean Reward: 9025.901. Std of Reward: 21.754. Training.
[INFO] gewu. Step: 9740000. Time Elapsed: 451.873 s. Mean Reward: 9010.826. Std of Reward: 11.766. Training.
[INFO] gewu. Step: 9760000. Time Elapsed: 462.915 s. Mean Reward: 7026.510. Std of Reward: 2753.876. Training.
[INFO] gewu. Step: 9780000. Time Elapsed: 473.321 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 9800000. Time Elapsed: 485.124 s. Mean Reward: 9005.274. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 9820000. Time Elapsed: 495.489 s. Mean Reward: 9013.756. Std of Reward: 100.764. Training.
[INFO] gewu. Step: 9840000. Time Elapsed: 501.922 s. Mean Reward: 9029.551. Std of Reward: 39.373. Training.
[INFO] gewu. Step: 9860000. Time Elapsed: 512.315 s. Mean Reward: 9016.672. Std of Reward: 73.591. Training.
[INFO] gewu. Step: 9880000. Time Elapsed: 522.814 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 9900000. Time Elapsed: 534.459 s. Mean Reward: 6884.740. Std of Reward: 2053.240. Training.
[INFO] gewu. Step: 9920000. Time Elapsed: 547.485 s. Mean Reward: 8967.776. Std of Reward: 104.078. Training.
[INFO] gewu. Step: 9940000. Time Elapsed: 558.015 s. Mean Reward: 8853.090. Std of Reward: 29.101. Training.
[INFO] gewu. Step: 9960000. Time Elapsed: 568.611 s. Mean Reward: 8933.267. Std of Reward: 41.348. Training.
[INFO] gewu. Step: 9980000. Time Elapsed: 578.856 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 10000000. Time Elapsed: 589.303 s. Mean Reward: 8824.066. Std of Reward: 10.485. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-9999580.onnx
[INFO] gewu. Step: 10020000. Time Elapsed: 599.735 s. Mean Reward: 8926.629. Std of Reward: 100.528. Training.
[INFO] gewu. Step: 10040000. Time Elapsed: 610.347 s. Mean Reward: 8890.133. Std of Reward: 45.008. Training.
[INFO] gewu. Step: 10060000. Time Elapsed: 620.537 s. Mean Reward: 8953.209. Std of Reward: 46.385. Training.
[INFO] gewu. Step: 10080000. Time Elapsed: 630.940 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 10100000. Time Elapsed: 641.260 s. Mean Reward: 8986.900. Std of Reward: 54.472. Training.
[INFO] gewu. Step: 10120000. Time Elapsed: 652.020 s. Mean Reward: 8850.787. Std of Reward: 131.377. Training.
[INFO] gewu. Step: 10140000. Time Elapsed: 661.847 s. Mean Reward: 8770.230. Std of Reward: 27.317. Training.
[INFO] gewu. Step: 10160000. Time Elapsed: 673.370 s. Mean Reward: 8394.465. Std of Reward: 638.827. Training.
[INFO] gewu. Step: 10180000. Time Elapsed: 683.781 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 10200000. Time Elapsed: 694.232 s. Mean Reward: 8442.010. Std of Reward: 520.703. Training.
[INFO] gewu. Step: 10220000. Time Elapsed: 705.516 s. Mean Reward: 8883.891. Std of Reward: 111.938. Training.
[INFO] gewu. Step: 10240000. Time Elapsed: 715.934 s. Mean Reward: 8926.046. Std of Reward: 97.599. Training.
[INFO] gewu. Step: 10260000. Time Elapsed: 726.433 s. Mean Reward: 5989.549. Std of Reward: 4225.803. Training.
[INFO] gewu. Step: 10280000. Time Elapsed: 732.579 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 10300000. Time Elapsed: 742.731 s. Mean Reward: 8859.429. Std of Reward: 76.345. Training.
[INFO] gewu. Step: 10320000. Time Elapsed: 753.364 s. Mean Reward: 8646.715. Std of Reward: 482.198. Training.
[INFO] gewu. Step: 10340000. Time Elapsed: 763.762 s. Mean Reward: 6339.404. Std of Reward: 3725.447. Training.
[INFO] gewu. Step: 10360000. Time Elapsed: 774.273 s. Mean Reward: 8787.036. Std of Reward: 6.038. Training.
[INFO] gewu. Step: 10380000. Time Elapsed: 784.445 s. Mean Reward: 8694.826. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 10400000. Time Elapsed: 794.842 s. Mean Reward: 8419.134. Std of Reward: 595.608. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-10399029.onnx
[INFO] gewu. Step: 10420000. Time Elapsed: 805.616 s. Mean Reward: 8642.537. Std of Reward: 117.025. Training.
[INFO] gewu. Step: 10440000. Time Elapsed: 815.807 s. Mean Reward: 8118.068. Std of Reward: 723.883. Training.
[INFO] gewu. Step: 10460000. Time Elapsed: 826.083 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 10480000. Time Elapsed: 836.193 s. Mean Reward: 8384.656. Std of Reward: 436.974. Training.
[INFO] gewu. Step: 10500000. Time Elapsed: 845.737 s. Mean Reward: 8575.158. Std of Reward: 131.641. Training.
[INFO] gewu. Step: 10520000. Time Elapsed: 856.103 s. Mean Reward: 8578.365. Std of Reward: 133.616. Training.
[INFO] gewu. Step: 10540000. Time Elapsed: 866.750 s. Mean Reward: 7053.823. Std of Reward: 2577.212. Training.
[INFO] gewu. Step: 10560000. Time Elapsed: 876.978 s. No episode was completed since last summary. Training.
[INFO] gewu. Step: 10580000. Time Elapsed: 887.403 s. Mean Reward: 7423.811. Std of Reward: 1548.951. Training.
[INFO] gewu. Step: 10600000. Time Elapsed: 898.305 s. Mean Reward: 8190.464. Std of Reward: 768.723. Training.
[INFO] gewu. Step: 10620000. Time Elapsed: 909.149 s. Mean Reward: 8510.784. Std of Reward: 49.510. Training.
[INFO] gewu. Step: 10640000. Time Elapsed: 919.584 s. Mean Reward: 8370.254. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 10660000. Time Elapsed: 925.363 s. Mean Reward: 8476.953. Std of Reward: 1.707. Training.
[INFO] gewu. Step: 10680000. Time Elapsed: 935.721 s. Mean Reward: 7825.118. Std of Reward: 1871.182. Training.
[INFO] gewu. Step: 10700000. Time Elapsed: 946.877 s. Mean Reward: 8529.773. Std of Reward: 55.589. Training.
[INFO] gewu. Step: 10720000. Time Elapsed: 957.601 s. Mean Reward: 8495.993. Std of Reward: 101.629. Training.
[INFO] gewu. Step: 10740000. Time Elapsed: 968.021 s. Mean Reward: 4725.000. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 10760000. Time Elapsed: 978.096 s. Mean Reward: 8347.758. Std of Reward: 152.332. Training.
[INFO] gewu. Step: 10780000. Time Elapsed: 988.897 s. Mean Reward: 8393.204. Std of Reward: 77.880. Training.
[INFO] gewu. Step: 10800000. Time Elapsed: 998.874 s. Mean Reward: 7202.482. Std of Reward: 1867.077. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-10799972.onnx
[INFO] gewu. Step: 10820000. Time Elapsed: 1008.802 s. Mean Reward: 7025.290. Std of Reward: 1295.464. Training.
[INFO] gewu. Step: 10840000. Time Elapsed: 1019.158 s. Mean Reward: 6492.049. Std of Reward: 1881.482. Training.
[INFO] gewu. Step: 10860000. Time Elapsed: 1029.570 s. Mean Reward: 8257.318. Std of Reward: 93.070. Training.
[INFO] gewu. Step: 10880000. Time Elapsed: 1040.775 s. Mean Reward: 7272.925. Std of Reward: 2490.185. Training.
[INFO] gewu. Step: 10900000. Time Elapsed: 1051.112 s. Mean Reward: 8364.204. Std of Reward: 95.182. Training.
[INFO] gewu. Step: 10920000. Time Elapsed: 1061.461 s. Mean Reward: 8382.539. Std of Reward: 48.061. Training.
[INFO] gewu. Step: 10940000. Time Elapsed: 1071.811 s. Mean Reward: 8334.292. Std of Reward: 100.701. Training.
[INFO] gewu. Step: 10960000. Time Elapsed: 1082.414 s. Mean Reward: 6884.312. Std of Reward: 2567.693. Training.
[INFO] gewu. Step: 10980000. Time Elapsed: 1093.615 s. Mean Reward: 8281.877. Std of Reward: 22.148. Training.
[INFO] gewu. Step: 11000000. Time Elapsed: 1104.046 s. Mean Reward: 8284.510. Std of Reward: 29.649. Training.
[INFO] gewu. Step: 11020000. Time Elapsed: 1114.375 s. Mean Reward: 8219.717. Std of Reward: 26.920. Training.
[INFO] gewu. Step: 11040000. Time Elapsed: 1123.480 s. Mean Reward: 8290.493. Std of Reward: 33.288. Training.
[INFO] gewu. Step: 11060000. Time Elapsed: 1134.120 s. Mean Reward: 6091.167. Std of Reward: 2788.203. Training.
[INFO] gewu. Step: 11080000. Time Elapsed: 1140.510 s. Mean Reward: 8237.737. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 11100000. Time Elapsed: 1150.735 s. Mean Reward: 5404.010. Std of Reward: 3024.406. Training.
[INFO] gewu. Step: 11120000. Time Elapsed: 1161.852 s. Mean Reward: 8251.549. Std of Reward: 150.886. Training.
[INFO] gewu. Step: 11140000. Time Elapsed: 1172.220 s. Mean Reward: 8232.226. Std of Reward: 73.128. Training.
[INFO] gewu. Step: 11160000. Time Elapsed: 1183.030 s. Mean Reward: 6937.642. Std of Reward: 2158.419. Training.
[INFO] gewu. Step: 11180000. Time Elapsed: 1193.497 s. Mean Reward: 7826.574. Std of Reward: 425.993. Training.
[INFO] gewu. Step: 11200000. Time Elapsed: 1203.978 s. Mean Reward: 7123.491. Std of Reward: 1593.828. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-11199944.onnx
[INFO] gewu. Step: 11220000. Time Elapsed: 1214.709 s. Mean Reward: 7613.066. Std of Reward: 1157.337. Training.
[INFO] gewu. Step: 11240000. Time Elapsed: 1225.143 s. Mean Reward: 8289.830. Std of Reward: 77.482. Training.
[INFO] gewu. Step: 11260000. Time Elapsed: 1235.606 s. Mean Reward: 6837.150. Std of Reward: 1818.790. Training.
[INFO] gewu. Step: 11280000. Time Elapsed: 1245.832 s. Mean Reward: 5377.736. Std of Reward: 3403.036. Training.
[INFO] gewu. Step: 11300000. Time Elapsed: 1256.465 s. Mean Reward: 5674.757. Std of Reward: 3522.626. Training.
[INFO] gewu. Step: 11320000. Time Elapsed: 1266.755 s. Mean Reward: 4951.558. Std of Reward: 3355.601. Training.
[INFO] gewu. Step: 11340000. Time Elapsed: 1277.315 s. Mean Reward: 8153.225. Std of Reward: 143.730. Training.
[INFO] gewu. Step: 11360000. Time Elapsed: 1288.400 s. Mean Reward: 8554.518. Std of Reward: 225.405. Training.
[INFO] gewu. Step: 11380000. Time Elapsed: 1302.432 s. Mean Reward: 8234.789. Std of Reward: 202.888. Training.
[INFO] gewu. Step: 11400000. Time Elapsed: 1316.480 s. Mean Reward: 6319.419. Std of Reward: 2464.461. Training.
[INFO] gewu. Step: 11420000. Time Elapsed: 1331.000 s. Mean Reward: 8225.854. Std of Reward: 138.653. Training.
[INFO] gewu. Step: 11440000. Time Elapsed: 1345.482 s. Mean Reward: 7706.502. Std of Reward: 1038.865. Training.
[INFO] gewu. Step: 11460000. Time Elapsed: 1359.304 s. Mean Reward: 8053.461. Std of Reward: 233.847. Training.
[INFO] gewu. Step: 11480000. Time Elapsed: 1373.328 s. Mean Reward: 8144.224. Std of Reward: 59.259. Training.
[INFO] gewu. Step: 11500000. Time Elapsed: 1387.808 s. Mean Reward: 8214.821. Std of Reward: 89.366. Training.
[INFO] gewu. Step: 11520000. Time Elapsed: 1402.422 s. Mean Reward: 6803.045. Std of Reward: 1942.666. Training.
[INFO] gewu. Step: 11540000. Time Elapsed: 1415.849 s. Mean Reward: 8180.993. Std of Reward: 61.776. Training.
[INFO] gewu. Step: 11560000. Time Elapsed: 1421.881 s. Mean Reward: 7111.488. Std of Reward: 1598.049. Training.
[INFO] gewu. Step: 11580000. Time Elapsed: 1434.897 s. Mean Reward: 6495.845. Std of Reward: 3272.020. Training.
[INFO] gewu. Step: 11600000. Time Elapsed: 1447.545 s. Mean Reward: 8218.030. Std of Reward: 76.568. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-11599574.onnx
[INFO] gewu. Step: 11620000. Time Elapsed: 1462.024 s. Mean Reward: 6465.952. Std of Reward: 3275.424. Training.
[INFO] gewu. Step: 11640000. Time Elapsed: 1476.302 s. Mean Reward: 7620.296. Std of Reward: 1178.327. Training.
[INFO] gewu. Step: 11660000. Time Elapsed: 1490.948 s. Mean Reward: 5567.743. Std of Reward: 2716.705. Training.
[INFO] gewu. Step: 11680000. Time Elapsed: 1503.538 s. Mean Reward: 5947.445. Std of Reward: 3226.846. Training.
[INFO] gewu. Step: 11700000. Time Elapsed: 1517.669 s. Mean Reward: 8109.781. Std of Reward: 52.132. Training.
[INFO] gewu. Step: 11720000. Time Elapsed: 1532.325 s. Mean Reward: 8098.818. Std of Reward: 79.118. Training.
[INFO] gewu. Step: 11740000. Time Elapsed: 1544.109 s. Mean Reward: 8230.176. Std of Reward: 182.388. Training.
[INFO] gewu. Step: 11760000. Time Elapsed: 1556.037 s. Mean Reward: 8114.968. Std of Reward: 98.666. Training.
[INFO] gewu. Step: 11780000. Time Elapsed: 1570.669 s. Mean Reward: 5406.503. Std of Reward: 3685.188. Training.
[INFO] gewu. Step: 11800000. Time Elapsed: 1584.546 s. Mean Reward: 8188.838. Std of Reward: 226.602. Training.
[INFO] gewu. Step: 11820000. Time Elapsed: 1599.220 s. Mean Reward: 8116.275. Std of Reward: 116.250. Training.
[INFO] gewu. Step: 11840000. Time Elapsed: 1612.971 s. Mean Reward: 7965.925. Std of Reward: 341.068. Training.
[INFO] gewu. Step: 11860000. Time Elapsed: 1626.677 s. Mean Reward: 7087.283. Std of Reward: 2670.461. Training.
[INFO] gewu. Step: 11880000. Time Elapsed: 1640.838 s. Mean Reward: 8265.226. Std of Reward: 134.217. Training.
[INFO] gewu. Step: 11900000. Time Elapsed: 1654.262 s. Mean Reward: 8247.588. Std of Reward: 143.007. Training.
[INFO] gewu. Step: 11920000. Time Elapsed: 1668.756 s. Mean Reward: 8430.643. Std of Reward: 103.297. Training.
[INFO] gewu. Step: 11940000. Time Elapsed: 1682.036 s. Mean Reward: 7778.833. Std of Reward: 995.764. Training.
[INFO] gewu. Step: 11960000. Time Elapsed: 1695.502 s. Mean Reward: 8377.495. Std of Reward: 122.466. Training.
[INFO] gewu. Step: 11980000. Time Elapsed: 1708.687 s. Mean Reward: 6672.227. Std of Reward: 3351.328. Training.
[INFO] gewu. Step: 12000000. Time Elapsed: 1716.206 s. Mean Reward: 8423.281. Std of Reward: 197.720. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-11999548.onnx
[INFO] gewu. Step: 12020000. Time Elapsed: 1729.574 s. Mean Reward: 6270.303. Std of Reward: 3552.909. Training.
[INFO] gewu. Step: 12040000. Time Elapsed: 1742.912 s. Mean Reward: 6053.759. Std of Reward: 3471.968. Training.
[INFO] gewu. Step: 12060000. Time Elapsed: 1756.273 s. Mean Reward: 8422.158. Std of Reward: 239.473. Training.
[INFO] gewu. Step: 12080000. Time Elapsed: 1769.677 s. Mean Reward: 6279.029. Std of Reward: 3236.203. Training.
[INFO] gewu. Step: 12100000. Time Elapsed: 1784.037 s. Mean Reward: 5903.311. Std of Reward: 3506.052. Training.
[INFO] gewu. Step: 12120000. Time Elapsed: 1797.486 s. Mean Reward: 7882.244. Std of Reward: 1016.674. Training.
[INFO] gewu. Step: 12140000. Time Elapsed: 1811.352 s. Mean Reward: 8269.059. Std of Reward: 142.482. Training.
[INFO] gewu. Step: 12160000. Time Elapsed: 1825.442 s. Mean Reward: 8349.942. Std of Reward: 141.152. Training.
[INFO] gewu. Step: 12180000. Time Elapsed: 1840.160 s. Mean Reward: 7707.849. Std of Reward: 723.706. Training.
[INFO] gewu. Step: 12200000. Time Elapsed: 1854.417 s. Mean Reward: 6408.761. Std of Reward: 2827.361. Training.
[INFO] gewu. Step: 12220000. Time Elapsed: 1868.499 s. Mean Reward: 2915.445. Std of Reward: 3031.225. Training.
[INFO] gewu. Step: 12240000. Time Elapsed: 1882.962 s. Mean Reward: 6714.055. Std of Reward: 2716.311. Training.
[INFO] gewu. Step: 12260000. Time Elapsed: 1897.096 s. Mean Reward: 7997.113. Std of Reward: 95.818. Training.
[INFO] gewu. Step: 12280000. Time Elapsed: 1911.493 s. Mean Reward: 8098.681. Std of Reward: 42.169. Training.
[INFO] gewu. Step: 12300000. Time Elapsed: 1925.125 s. Mean Reward: 8144.057. Std of Reward: 111.803. Training.
[INFO] gewu. Step: 12320000. Time Elapsed: 1938.349 s. Mean Reward: 7970.708. Std of Reward: 325.787. Training.
[INFO] gewu. Step: 12340000. Time Elapsed: 1952.415 s. Mean Reward: 6947.387. Std of Reward: 2448.669. Training.
[INFO] gewu. Step: 12360000. Time Elapsed: 1965.844 s. Mean Reward: 8034.593. Std of Reward: 78.133. Training.
[INFO] gewu. Step: 12380000. Time Elapsed: 1979.372 s. Mean Reward: 6191.470. Std of Reward: 3038.269. Training.
[INFO] gewu. Step: 12400000. Time Elapsed: 1986.572 s. Mean Reward: 7544.429. Std of Reward: 1495.943. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-12399231.onnx
[INFO] gewu. Step: 12420000. Time Elapsed: 2000.236 s. Mean Reward: 4985.737. Std of Reward: 3747.912. Training.
[INFO] gewu. Step: 12440000. Time Elapsed: 2013.855 s. Mean Reward: 8181.401. Std of Reward: 166.571. Training.
[INFO] gewu. Step: 12460000. Time Elapsed: 2027.620 s. Mean Reward: 6607.852. Std of Reward: 3032.379. Training.
[INFO] gewu. Step: 12480000. Time Elapsed: 2041.119 s. Mean Reward: 8120.692. Std of Reward: 298.498. Training.
[INFO] gewu. Step: 12500000. Time Elapsed: 2051.072 s. Mean Reward: 7987.926. Std of Reward: 91.461. Training.
[INFO] gewu. Step: 12520000. Time Elapsed: 2061.481 s. Mean Reward: 6952.721. Std of Reward: 2720.168. Training.
[INFO] gewu. Step: 12540000. Time Elapsed: 2072.060 s. Mean Reward: 6501.221. Std of Reward: 3176.845. Training.
[INFO] gewu. Step: 12560000. Time Elapsed: 2082.764 s. Mean Reward: 8231.107. Std of Reward: 255.339. Training.
[INFO] gewu. Step: 12580000. Time Elapsed: 2093.380 s. Mean Reward: 6574.851. Std of Reward: 3247.857. Training.
[INFO] gewu. Step: 12600000. Time Elapsed: 2103.784 s. Mean Reward: 8586.169. Std of Reward: 276.968. Training.
[INFO] gewu. Step: 12620000. Time Elapsed: 2114.229 s. Mean Reward: 7891.999. Std of Reward: 945.661. Training.
[INFO] gewu. Step: 12640000. Time Elapsed: 2124.636 s. Mean Reward: 8093.524. Std of Reward: 32.612. Training.
[INFO] gewu. Step: 12660000. Time Elapsed: 2135.280 s. Mean Reward: 8216.061. Std of Reward: 106.289. Training.
[INFO] gewu. Step: 12680000. Time Elapsed: 2145.781 s. Mean Reward: 8062.403. Std of Reward: 412.671. Training.
[INFO] gewu. Step: 12700000. Time Elapsed: 2156.517 s. Mean Reward: 6947.118. Std of Reward: 2806.861. Training.
[INFO] gewu. Step: 12720000. Time Elapsed: 2167.032 s. Mean Reward: 8430.822. Std of Reward: 299.152. Training.
[INFO] gewu. Step: 12740000. Time Elapsed: 2177.620 s. Mean Reward: 6470.062. Std of Reward: 3341.211. Training.
[INFO] gewu. Step: 12760000. Time Elapsed: 2188.023 s. Mean Reward: 8090.865. Std of Reward: 89.148. Training.
[INFO] gewu. Step: 12780000. Time Elapsed: 2198.403 s. Mean Reward: 7049.735. Std of Reward: 2413.186. Training.
[INFO] gewu. Step: 12800000. Time Elapsed: 2204.649 s. Mean Reward: 5713.001. Std of Reward: 2825.188. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-12799555.onnx
[INFO] gewu. Step: 12820000. Time Elapsed: 2215.073 s. Mean Reward: 8086.682. Std of Reward: 169.083. Training.
[INFO] gewu. Step: 12840000. Time Elapsed: 2225.805 s. Mean Reward: 6642.367. Std of Reward: 1869.568. Training.
[INFO] gewu. Step: 12860000. Time Elapsed: 2236.273 s. Mean Reward: 7721.492. Std of Reward: 798.349. Training.
[INFO] gewu. Step: 12880000. Time Elapsed: 2246.660 s. Mean Reward: 8535.592. Std of Reward: 593.731. Training.
[INFO] gewu. Step: 12900000. Time Elapsed: 2258.121 s. Mean Reward: 6666.349. Std of Reward: 2819.961. Training.
[INFO] gewu. Step: 12920000. Time Elapsed: 2268.448 s. Mean Reward: 7034.968. Std of Reward: 2186.494. Training.
[INFO] gewu. Step: 12940000. Time Elapsed: 2279.004 s. Mean Reward: 8459.107. Std of Reward: 524.712. Training.
[INFO] gewu. Step: 12960000. Time Elapsed: 2289.570 s. Mean Reward: 6509.863. Std of Reward: 3283.691. Training.
[INFO] gewu. Step: 12980000. Time Elapsed: 2300.103 s. Mean Reward: 8426.755. Std of Reward: 283.677. Training.
[INFO] gewu. Step: 13000000. Time Elapsed: 2310.687 s. Mean Reward: 6419.772. Std of Reward: 3064.094. Training.
[INFO] gewu. Step: 13020000. Time Elapsed: 2321.543 s. Mean Reward: 3135.753. Std of Reward: 3018.600. Training.
[INFO] gewu. Step: 13040000. Time Elapsed: 2332.325 s. Mean Reward: 7995.122. Std of Reward: 174.817. Training.
[INFO] gewu. Step: 13060000. Time Elapsed: 2345.898 s. Mean Reward: 8030.171. Std of Reward: 98.029. Training.
[INFO] gewu. Step: 13080000. Time Elapsed: 2360.140 s. Mean Reward: 8083.904. Std of Reward: 68.355. Training.
[INFO] gewu. Step: 13100000. Time Elapsed: 2373.886 s. Mean Reward: 7462.347. Std of Reward: 558.768. Training.
[INFO] gewu. Step: 13120000. Time Elapsed: 2388.172 s. Mean Reward: 6718.500. Std of Reward: 1197.763. Training.
[INFO] gewu. Step: 13140000. Time Elapsed: 2402.129 s. Mean Reward: 7100.399. Std of Reward: 1786.846. Training.
[INFO] gewu. Step: 13160000. Time Elapsed: 2416.361 s. Mean Reward: 7076.360. Std of Reward: 2339.580. Training.
[INFO] gewu. Step: 13180000. Time Elapsed: 2429.602 s. Mean Reward: 5315.822. Std of Reward: 3386.514. Training.
[INFO] gewu. Step: 13200000. Time Elapsed: 2437.429 s. Mean Reward: 5627.457. Std of Reward: 2314.338. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-13199513.onnx
[INFO] gewu. Step: 13220000. Time Elapsed: 2452.150 s. Mean Reward: 6216.510. Std of Reward: 4142.109. Training.
[INFO] gewu. Step: 13240000. Time Elapsed: 2466.867 s. Mean Reward: 6204.328. Std of Reward: 3058.541. Training.
[INFO] gewu. Step: 13260000. Time Elapsed: 2481.115 s. Mean Reward: 4929.988. Std of Reward: 3562.741. Training.
[INFO] gewu. Step: 13280000. Time Elapsed: 2494.670 s. Mean Reward: 4620.330. Std of Reward: 3621.024. Training.
[INFO] gewu. Step: 13300000. Time Elapsed: 2508.868 s. Mean Reward: 5805.638. Std of Reward: 3506.337. Training.
[INFO] gewu. Step: 13320000. Time Elapsed: 2522.670 s. Mean Reward: 8031.024. Std of Reward: 119.006. Training.
[INFO] gewu. Step: 13340000. Time Elapsed: 2536.028 s. Mean Reward: 6533.437. Std of Reward: 2119.783. Training.
[INFO] gewu. Step: 13360000. Time Elapsed: 2549.337 s. Mean Reward: 7873.091. Std of Reward: 74.348. Training.
[INFO] gewu. Step: 13380000. Time Elapsed: 2562.447 s. Mean Reward: 7001.065. Std of Reward: 2186.948. Training.
[INFO] gewu. Step: 13400000. Time Elapsed: 2576.142 s. Mean Reward: 6461.840. Std of Reward: 3135.700. Training.
[INFO] gewu. Step: 13420000. Time Elapsed: 2590.445 s. Mean Reward: 8006.839. Std of Reward: 89.407. Training.
[INFO] gewu. Step: 13440000. Time Elapsed: 2604.399 s. Mean Reward: 5656.754. Std of Reward: 2923.498. Training.
[INFO] gewu. Step: 13460000. Time Elapsed: 2618.719 s. Mean Reward: 7064.000. Std of Reward: 1805.603. Training.
[INFO] gewu. Step: 13480000. Time Elapsed: 2632.756 s. Mean Reward: 7992.960. Std of Reward: 70.593. Training.
[INFO] gewu. Step: 13500000. Time Elapsed: 2646.131 s. Mean Reward: 8136.140. Std of Reward: 117.697. Training.
[INFO] gewu. Step: 13520000. Time Elapsed: 2659.783 s. Mean Reward: 7175.402. Std of Reward: 2332.839. Training.
[INFO] gewu. Step: 13540000. Time Elapsed: 2673.087 s. Mean Reward: 7151.501. Std of Reward: 1209.124. Training.
[INFO] gewu. Step: 13560000. Time Elapsed: 2686.604 s. Mean Reward: 6565.187. Std of Reward: 3056.283. Training.
[INFO] gewu. Step: 13580000. Time Elapsed: 2699.960 s. Mean Reward: 7590.943. Std of Reward: 889.756. Training.
[INFO] gewu. Step: 13600000. Time Elapsed: 2713.012 s. Mean Reward: 8045.809. Std of Reward: 110.874. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-13599095.onnx
[INFO] gewu. Step: 13620000. Time Elapsed: 2726.322 s. Mean Reward: 5363.068. Std of Reward: 3644.710. Training.
[INFO] gewu. Step: 13640000. Time Elapsed: 2739.802 s. Mean Reward: 6341.402. Std of Reward: 2971.739. Training.
[INFO] gewu. Step: 13660000. Time Elapsed: 2746.989 s. Mean Reward: 7013.032. Std of Reward: 1680.759. Training.
[INFO] gewu. Step: 13680000. Time Elapsed: 2760.615 s. Mean Reward: 8028.739. Std of Reward: 73.363. Training.
[INFO] gewu. Step: 13700000. Time Elapsed: 2773.501 s. Mean Reward: 8036.100. Std of Reward: 148.829. Training.
[INFO] gewu. Step: 13720000. Time Elapsed: 2786.834 s. Mean Reward: 7888.917. Std of Reward: 58.538. Training.
[INFO] gewu. Step: 13740000. Time Elapsed: 2800.286 s. Mean Reward: 6929.129. Std of Reward: 2310.430. Training.
[INFO] gewu. Step: 13760000. Time Elapsed: 2813.805 s. Mean Reward: 5342.417. Std of Reward: 3975.758. Training.
[INFO] gewu. Step: 13780000. Time Elapsed: 2824.566 s. Mean Reward: 7466.780. Std of Reward: 1462.295. Training.
[INFO] gewu. Step: 13800000. Time Elapsed: 2837.421 s. Mean Reward: 8093.128. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 13820000. Time Elapsed: 2851.082 s. Mean Reward: 7167.708. Std of Reward: 2605.261. Training.
[INFO] gewu. Step: 13840000. Time Elapsed: 2865.123 s. Mean Reward: 6441.299. Std of Reward: 3113.328. Training.
[INFO] gewu. Step: 13860000. Time Elapsed: 2877.191 s. Mean Reward: 5398.703. Std of Reward: 3621.029. Training.
[INFO] gewu. Step: 13880000. Time Elapsed: 2887.163 s. Mean Reward: 2759.571. Std of Reward: 1945.067. Training.
[INFO] gewu. Step: 13900000. Time Elapsed: 2897.492 s. Mean Reward: 6182.484. Std of Reward: 3118.266. Training.
[INFO] gewu. Step: 13920000. Time Elapsed: 2907.915 s. Mean Reward: 7988.609. Std of Reward: 307.529. Training.
[INFO] gewu. Step: 13940000. Time Elapsed: 2918.590 s. Mean Reward: 8351.473. Std of Reward: 166.212. Training.
[INFO] gewu. Step: 13960000. Time Elapsed: 2928.098 s. Mean Reward: 6255.488. Std of Reward: 3292.965. Training.
[INFO] gewu. Step: 13980000. Time Elapsed: 2938.530 s. Mean Reward: 8052.291. Std of Reward: 84.724. Training.
[INFO] gewu. Step: 14000000. Time Elapsed: 2949.070 s. Mean Reward: 6903.040. Std of Reward: 2453.022. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-13999216.onnx
[INFO] gewu. Step: 14020000. Time Elapsed: 2959.724 s. Mean Reward: 8016.383. Std of Reward: 226.405. Training.
[INFO] gewu. Step: 14040000. Time Elapsed: 2970.362 s. Mean Reward: 7657.199. Std of Reward: 865.182. Training.
[INFO] gewu. Step: 14060000. Time Elapsed: 2981.160 s. Mean Reward: 6433.991. Std of Reward: 2721.394. Training.
[INFO] gewu. Step: 14080000. Time Elapsed: 2987.873 s. Mean Reward: 6304.688. Std of Reward: 3233.789. Training.
[INFO] gewu. Step: 14100000. Time Elapsed: 2998.251 s. Mean Reward: 5516.767. Std of Reward: 3758.995. Training.
[INFO] gewu. Step: 14120000. Time Elapsed: 3008.820 s. Mean Reward: 6733.979. Std of Reward: 2934.739. Training.
[INFO] gewu. Step: 14140000. Time Elapsed: 3020.022 s. Mean Reward: 8079.370. Std of Reward: 136.279. Training.
[INFO] gewu. Step: 14160000. Time Elapsed: 3030.496 s. Mean Reward: 8188.005. Std of Reward: 139.106. Training.
[INFO] gewu. Step: 14180000. Time Elapsed: 3040.149 s. Mean Reward: 7912.217. Std of Reward: 47.719. Training.
[INFO] gewu. Step: 14200000. Time Elapsed: 3051.219 s. Mean Reward: 8052.778. Std of Reward: 95.206. Training.
[INFO] gewu. Step: 14220000. Time Elapsed: 3062.031 s. Mean Reward: 7119.637. Std of Reward: 2220.844. Training.
[INFO] gewu. Step: 14240000. Time Elapsed: 3071.729 s. Mean Reward: 7785.877. Std of Reward: 522.491. Training.
[INFO] gewu. Step: 14260000. Time Elapsed: 3082.151 s. Mean Reward: 3755.905. Std of Reward: 4414.522. Training.
[INFO] gewu. Step: 14280000. Time Elapsed: 3092.153 s. Mean Reward: 6628.769. Std of Reward: 3128.138. Training.
[INFO] gewu. Step: 14300000. Time Elapsed: 3102.749 s. Mean Reward: 6378.405. Std of Reward: 3144.776. Training.
[INFO] gewu. Step: 14320000. Time Elapsed: 3113.324 s. Mean Reward: 3125.207. Std of Reward: 5358.871. Training.
[INFO] gewu. Step: 14340000. Time Elapsed: 3123.615 s. Mean Reward: 8109.054. Std of Reward: 198.644. Training.
[INFO] gewu. Step: 14360000. Time Elapsed: 3134.322 s. Mean Reward: 7168.157. Std of Reward: 2213.504. Training.
[INFO] gewu. Step: 14380000. Time Elapsed: 3144.245 s. Mean Reward: 6745.576. Std of Reward: 2865.191. Training.
[INFO] gewu. Step: 14400000. Time Elapsed: 3154.507 s. Mean Reward: 8042.280. Std of Reward: 96.732. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-14399053.onnx
[INFO] gewu. Step: 14420000. Time Elapsed: 3165.319 s. Mean Reward: 7761.390. Std of Reward: 86.242. Training.
[INFO] gewu. Step: 14440000. Time Elapsed: 3176.810 s. Mean Reward: 7868.380. Std of Reward: 189.789. Training.
[INFO] gewu. Step: 14460000. Time Elapsed: 3187.520 s. Mean Reward: 6746.404. Std of Reward: 2388.735. Training.
[INFO] gewu. Step: 14480000. Time Elapsed: 3197.681 s. Mean Reward: 5236.903. Std of Reward: 3987.180. Training.
[INFO] gewu. Step: 14500000. Time Elapsed: 3207.735 s. Mean Reward: 4446.330. Std of Reward: 4115.909. Training.
[INFO] gewu. Step: 14520000. Time Elapsed: 3214.310 s. Mean Reward: 6145.318. Std of Reward: 2819.814. Training.
[INFO] gewu. Step: 14540000. Time Elapsed: 3225.010 s. Mean Reward: 6266.648. Std of Reward: 3004.351. Training.
[INFO] gewu. Step: 14560000. Time Elapsed: 3234.969 s. Mean Reward: 5756.369. Std of Reward: 3659.563. Training.
[INFO] gewu. Step: 14580000. Time Elapsed: 3244.718 s. Mean Reward: 6365.256. Std of Reward: 2957.732. Training.
[INFO] gewu. Step: 14600000. Time Elapsed: 3255.172 s. Mean Reward: 7960.292. Std of Reward: 32.943. Training.
[INFO] gewu. Step: 14620000. Time Elapsed: 3265.548 s. Mean Reward: 7920.556. Std of Reward: 96.683. Training.
[INFO] gewu. Step: 14640000. Time Elapsed: 3275.859 s. Mean Reward: 7383.886. Std of Reward: 838.565. Training.
[INFO] gewu. Step: 14660000. Time Elapsed: 3286.195 s. Mean Reward: 8251.092. Std of Reward: 190.552. Training.
[INFO] gewu. Step: 14680000. Time Elapsed: 3296.934 s. Mean Reward: 4969.476. Std of Reward: 3813.592. Training.
[INFO] gewu. Step: 14700000. Time Elapsed: 3307.254 s. Mean Reward: 8202.924. Std of Reward: 133.969. Training.
[INFO] gewu. Step: 14720000. Time Elapsed: 3317.351 s. Mean Reward: 6886.261. Std of Reward: 2116.230. Training.
[INFO] gewu. Step: 14740000. Time Elapsed: 3328.375 s. Mean Reward: 6607.519. Std of Reward: 2836.101. Training.
[INFO] gewu. Step: 14760000. Time Elapsed: 3339.122 s. Mean Reward: 5750.950. Std of Reward: 3377.027. Training.
[INFO] gewu. Step: 14780000. Time Elapsed: 3348.606 s. Mean Reward: 1686.370. Std of Reward: 0.000. Training.
[INFO] gewu. Step: 14800000. Time Elapsed: 3359.606 s. Mean Reward: 8291.915. Std of Reward: 135.262. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-14799229.onnx
[INFO] gewu. Step: 14820000. Time Elapsed: 3370.181 s. Mean Reward: 5446.008. Std of Reward: 3402.096. Training.
[INFO] gewu. Step: 14840000. Time Elapsed: 3381.222 s. Mean Reward: 6848.395. Std of Reward: 2867.963. Training.
[INFO] gewu. Step: 14860000. Time Elapsed: 3391.214 s. Mean Reward: 7892.230. Std of Reward: 234.482. Training.
[INFO] gewu. Step: 14880000. Time Elapsed: 3402.130 s. Mean Reward: 8022.926. Std of Reward: 150.741. Training.
[INFO] gewu. Step: 14900000. Time Elapsed: 3412.012 s. Mean Reward: 7967.408. Std of Reward: 135.411. Training.
[INFO] gewu. Step: 14920000. Time Elapsed: 3424.605 s. Mean Reward: 5258.831. Std of Reward: 3212.469. Training.
[INFO] gewu. Step: 14940000. Time Elapsed: 3437.190 s. Mean Reward: 7660.300. Std of Reward: 563.062. Training.
[INFO] gewu. Step: 14960000. Time Elapsed: 3443.901 s. Mean Reward: 7964.160. Std of Reward: 51.032. Training.
[INFO] gewu. Step: 14980000. Time Elapsed: 3456.698 s. Mean Reward: 8148.604. Std of Reward: 206.965. Training.
[INFO] gewu. Step: 15000000. Time Elapsed: 3469.531 s. Mean Reward: 8243.022. Std of Reward: 177.587. Training.
[INFO] gewu. Step: 15020000. Time Elapsed: 3482.205 s. Mean Reward: 8189.987. Std of Reward: 29.978. Training.
[INFO] gewu. Step: 15040000. Time Elapsed: 3494.275 s. Mean Reward: 8028.117. Std of Reward: 104.152. Training.
[INFO] gewu. Step: 15060000. Time Elapsed: 3506.736 s. Mean Reward: 8063.938. Std of Reward: 143.336. Training.
[INFO] gewu. Step: 15080000. Time Elapsed: 3519.212 s. Mean Reward: 7994.821. Std of Reward: 86.257. Training.
[INFO] gewu. Step: 15100000. Time Elapsed: 3532.307 s. Mean Reward: 7987.475. Std of Reward: 217.174. Training.
[INFO] gewu. Step: 15120000. Time Elapsed: 3544.127 s. Mean Reward: 6766.097. Std of Reward: 3010.212. Training.
[INFO] gewu. Step: 15140000. Time Elapsed: 3556.830 s. Mean Reward: 5417.156. Std of Reward: 4254.850. Training.
[INFO] gewu. Step: 15160000. Time Elapsed: 3569.398 s. Mean Reward: 6694.130. Std of Reward: 2216.109. Training.
[INFO] gewu. Step: 15180000. Time Elapsed: 3581.988 s. Mean Reward: 8028.104. Std of Reward: 72.512. Training.
[INFO] gewu. Step: 15200000. Time Elapsed: 3594.429 s. Mean Reward: 7887.085. Std of Reward: 369.031. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-15199468.onnx
[INFO] gewu. Step: 15220000. Time Elapsed: 3607.730 s. Mean Reward: 6866.432. Std of Reward: 2656.652. Training.
[INFO] gewu. Step: 15240000. Time Elapsed: 3620.072 s. Mean Reward: 6477.552. Std of Reward: 2821.999. Training.
[INFO] gewu. Step: 15260000. Time Elapsed: 3632.716 s. Mean Reward: 8025.781. Std of Reward: 113.003. Training.
[INFO] gewu. Step: 15280000. Time Elapsed: 3645.304 s. Mean Reward: 8031.015. Std of Reward: 96.802. Training.
[INFO] gewu. Step: 15300000. Time Elapsed: 3657.717 s. Mean Reward: 8151.976. Std of Reward: 124.438. Training.
[INFO] gewu. Step: 15320000. Time Elapsed: 3670.290 s. Mean Reward: 8038.036. Std of Reward: 159.792. Training.
[INFO] gewu. Step: 15340000. Time Elapsed: 3682.909 s. Mean Reward: 8124.973. Std of Reward: 105.890. Training.
[INFO] gewu. Step: 15360000. Time Elapsed: 3695.432 s. Mean Reward: 8004.880. Std of Reward: 97.159. Training.
[INFO] gewu. Step: 15380000. Time Elapsed: 3702.133 s. Mean Reward: 7913.110. Std of Reward: 186.926. Training.
[INFO] gewu. Step: 15400000. Time Elapsed: 3715.420 s. Mean Reward: 7047.379. Std of Reward: 2454.727. Training.
[INFO] gewu. Step: 15420000. Time Elapsed: 3727.752 s. Mean Reward: 7882.311. Std of Reward: 92.725. Training.
[INFO] gewu. Step: 15440000. Time Elapsed: 3740.386 s. Mean Reward: 8006.293. Std of Reward: 69.828. Training.
[INFO] gewu. Step: 15460000. Time Elapsed: 3752.686 s. Mean Reward: 7268.502. Std of Reward: 1871.339. Training.
[INFO] gewu. Step: 15480000. Time Elapsed: 3765.109 s. Mean Reward: 8092.334. Std of Reward: 165.847. Training.
[INFO] gewu. Step: 15500000. Time Elapsed: 3778.283 s. Mean Reward: 7929.170. Std of Reward: 149.052. Training.
[INFO] gewu. Step: 15520000. Time Elapsed: 3790.545 s. Mean Reward: 7913.471. Std of Reward: 44.886. Training.
[INFO] gewu. Step: 15540000. Time Elapsed: 3803.878 s. Mean Reward: 7836.328. Std of Reward: 72.169. Training.
[INFO] gewu. Step: 15560000. Time Elapsed: 3816.503 s. Mean Reward: 7130.134. Std of Reward: 1878.136. Training.
[INFO] gewu. Step: 15580000. Time Elapsed: 3829.219 s. Mean Reward: 5699.576. Std of Reward: 3515.358. Training.
[INFO] gewu. Step: 15600000. Time Elapsed: 3841.677 s. Mean Reward: 7817.836. Std of Reward: 65.515. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-15599805.onnx
[INFO] gewu. Step: 15620000. Time Elapsed: 3853.767 s. Mean Reward: 4038.219. Std of Reward: 3867.070. Training.
[INFO] gewu. Step: 15640000. Time Elapsed: 3866.775 s. Mean Reward: 7041.217. Std of Reward: 2112.238. Training.
[INFO] gewu. Step: 15660000. Time Elapsed: 3879.337 s. Mean Reward: 6972.887. Std of Reward: 1690.464. Training.
[INFO] gewu. Step: 15680000. Time Elapsed: 3891.963 s. Mean Reward: 7782.200. Std of Reward: 83.661. Training.
[INFO] gewu. Step: 15700000. Time Elapsed: 3904.402 s. Mean Reward: 7720.066. Std of Reward: 105.604. Training.
[INFO] gewu. Step: 15720000. Time Elapsed: 3916.740 s. Mean Reward: 7764.407. Std of Reward: 118.907. Training.
[INFO] gewu. Step: 15740000. Time Elapsed: 3928.785 s. Mean Reward: 3765.749. Std of Reward: 7187.029. Training.
[INFO] gewu. Step: 15760000. Time Elapsed: 3941.711 s. Mean Reward: 7748.966. Std of Reward: 84.125. Training.
[INFO] gewu. Step: 15780000. Time Elapsed: 3954.639 s. Mean Reward: 7052.428. Std of Reward: 1158.122. Training.
[INFO] gewu. Step: 15800000. Time Elapsed: 3967.644 s. Mean Reward: 7695.841. Std of Reward: 135.456. Training.
[INFO] gewu. Step: 15820000. Time Elapsed: 3979.925 s. Mean Reward: 7746.050. Std of Reward: 163.008. Training.
[INFO] gewu. Step: 15840000. Time Elapsed: 3986.187 s. Mean Reward: 7774.562. Std of Reward: 70.151. Training.
[INFO] gewu. Step: 15860000. Time Elapsed: 3999.331 s. Mean Reward: 7745.936. Std of Reward: 169.461. Training.
[INFO] gewu. Step: 15880000. Time Elapsed: 4011.414 s. Mean Reward: 7031.354. Std of Reward: 2075.155. Training.
[INFO] gewu. Step: 15900000. Time Elapsed: 4024.269 s. Mean Reward: 6902.389. Std of Reward: 1105.518. Training.
[INFO] gewu. Step: 15920000. Time Elapsed: 4036.763 s. Mean Reward: 6500.263. Std of Reward: 2116.495. Training.
[INFO] gewu. Step: 15940000. Time Elapsed: 4049.213 s. Mean Reward: 6673.474. Std of Reward: 2599.766. Training.
[INFO] gewu. Step: 15960000. Time Elapsed: 4061.955 s. Mean Reward: 7863.920. Std of Reward: 81.981. Training.
[INFO] gewu. Step: 15980000. Time Elapsed: 4074.463 s. Mean Reward: 7928.007. Std of Reward: 153.858. Training.
[INFO] gewu. Step: 16000000. Time Elapsed: 4087.084 s. Mean Reward: 7783.134. Std of Reward: 154.851. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-15999812.onnx
[INFO] gewu. Step: 16020000. Time Elapsed: 4099.876 s. Mean Reward: 7919.356. Std of Reward: 34.860. Training.
[INFO] gewu. Step: 16040000. Time Elapsed: 4112.654 s. Mean Reward: 6388.464. Std of Reward: 3027.695. Training.
[INFO] gewu. Step: 16060000. Time Elapsed: 4124.784 s. Mean Reward: 7816.233. Std of Reward: 126.335. Training.
[INFO] gewu. Step: 16080000. Time Elapsed: 4137.027 s. Mean Reward: 7812.902. Std of Reward: 55.992. Training.
[INFO] gewu. Step: 16100000. Time Elapsed: 4149.402 s. Mean Reward: 4937.079. Std of Reward: 3740.084. Training.
[INFO] gewu. Step: 16120000. Time Elapsed: 4162.402 s. Mean Reward: 5531.685. Std of Reward: 3180.205. Training.
[INFO] gewu. Step: 16140000. Time Elapsed: 4174.805 s. Mean Reward: 5459.988. Std of Reward: 2772.709. Training.
[INFO] gewu. Step: 16160000. Time Elapsed: 4187.296 s. Mean Reward: 6784.784. Std of Reward: 2769.276. Training.
[INFO] gewu. Step: 16180000. Time Elapsed: 4199.964 s. Mean Reward: 7856.849. Std of Reward: 80.283. Training.
[INFO] gewu. Step: 16200000. Time Elapsed: 4212.603 s. Mean Reward: 7685.315. Std of Reward: 111.845. Training.
[INFO] gewu. Step: 16220000. Time Elapsed: 4225.338 s. Mean Reward: 7804.909. Std of Reward: 40.439. Training.
[INFO] gewu. Step: 16240000. Time Elapsed: 4237.551 s. Mean Reward: 6734.328. Std of Reward: 2462.997. Training.
[INFO] gewu. Step: 16260000. Time Elapsed: 4249.861 s. Mean Reward: 7772.236. Std of Reward: 35.794. Training.
[INFO] gewu. Step: 16280000. Time Elapsed: 4262.366 s. Mean Reward: 5857.857. Std of Reward: 4602.495. Training.
[INFO] gewu. Step: 16300000. Time Elapsed: 4275.041 s. Mean Reward: 7208.522. Std of Reward: 800.341. Training.
[INFO] gewu. Step: 16320000. Time Elapsed: 4282.788 s. Mean Reward: 7743.711. Std of Reward: 71.841. Training.
[INFO] gewu. Step: 16340000. Time Elapsed: 4294.981 s. Mean Reward: 7764.089. Std of Reward: 72.724. Training.
[INFO] gewu. Step: 16360000. Time Elapsed: 4306.765 s. Mean Reward: 7726.705. Std of Reward: 68.496. Training.
[INFO] gewu. Step: 16380000. Time Elapsed: 4319.074 s. Mean Reward: 6272.895. Std of Reward: 2774.238. Training.
[INFO] gewu. Step: 16400000. Time Elapsed: 4331.584 s. Mean Reward: 7698.088. Std of Reward: 0.000. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-16399891.onnx
[INFO] gewu. Step: 16420000. Time Elapsed: 4344.413 s. Mean Reward: 7754.960. Std of Reward: 139.751. Training.
[INFO] gewu. Step: 16440000. Time Elapsed: 4356.878 s. Mean Reward: 6669.461. Std of Reward: 2626.428. Training.
[INFO] gewu. Step: 16460000. Time Elapsed: 4370.242 s. Mean Reward: 5780.856. Std of Reward: 5589.012. Training.
[INFO] gewu. Step: 16480000. Time Elapsed: 4382.810 s. Mean Reward: 6542.512. Std of Reward: 2851.223. Training.
[INFO] gewu. Step: 16500000. Time Elapsed: 4395.128 s. Mean Reward: 5979.053. Std of Reward: 3431.983. Training.
[INFO] gewu. Step: 16520000. Time Elapsed: 4407.314 s. Mean Reward: 7833.440. Std of Reward: 124.866. Training.
[INFO] gewu. Step: 16540000. Time Elapsed: 4420.314 s. Mean Reward: 6054.866. Std of Reward: 3133.210. Training.
[INFO] gewu. Step: 16560000. Time Elapsed: 4433.198 s. Mean Reward: 7836.888. Std of Reward: 73.884. Training.
[INFO] gewu. Step: 16580000. Time Elapsed: 4444.467 s. Mean Reward: 7777.252. Std of Reward: 88.742. Training.
[INFO] gewu. Step: 16600000. Time Elapsed: 4457.735 s. Mean Reward: 6049.822. Std of Reward: 3077.414. Training.
[INFO] gewu. Step: 16620000. Time Elapsed: 4470.345 s. Mean Reward: 7853.757. Std of Reward: 143.646. Training.
[INFO] gewu. Step: 16640000. Time Elapsed: 4482.908 s. Mean Reward: 7850.933. Std of Reward: 68.600. Training.
[INFO] gewu. Step: 16660000. Time Elapsed: 4495.716 s. Mean Reward: 7780.661. Std of Reward: 188.625. Training.
[INFO] gewu. Step: 16680000. Time Elapsed: 4508.397 s. Mean Reward: 6856.192. Std of Reward: 2151.587. Training.
[INFO] gewu. Step: 16700000. Time Elapsed: 4520.930 s. Mean Reward: 6395.900. Std of Reward: 2489.567. Training.
[INFO] gewu. Step: 16720000. Time Elapsed: 4533.521 s. Mean Reward: 7328.956. Std of Reward: 562.629. Training.
[INFO] gewu. Step: 16740000. Time Elapsed: 4545.351 s. Mean Reward: 7764.481. Std of Reward: 111.773. Training.
[INFO] gewu. Step: 16760000. Time Elapsed: 4557.380 s. Mean Reward: 6703.552. Std of Reward: 1525.462. Training.
[INFO] gewu. Step: 16780000. Time Elapsed: 4569.890 s. Mean Reward: 7726.370. Std of Reward: 34.289. Training.
[INFO] gewu. Step: 16800000. Time Elapsed: 4582.124 s. Mean Reward: 6401.168. Std of Reward: 2359.204. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-16799879.onnx
[INFO] gewu. Step: 16820000. Time Elapsed: 4589.349 s. Mean Reward: 7730.349. Std of Reward: 97.800. Training.
[INFO] gewu. Step: 16840000. Time Elapsed: 4602.835 s. Mean Reward: 7804.715. Std of Reward: 100.121. Training.
[INFO] gewu. Step: 16860000. Time Elapsed: 4615.390 s. Mean Reward: 7016.781. Std of Reward: 1529.640. Training.
[INFO] gewu. Step: 16880000. Time Elapsed: 4627.160 s. Mean Reward: 7584.086. Std of Reward: 398.429. Training.
[INFO] gewu. Step: 16900000. Time Elapsed: 4639.225 s. Mean Reward: 6278.794. Std of Reward: 3112.382. Training.
[INFO] gewu. Step: 16920000. Time Elapsed: 4651.714 s. Mean Reward: 7628.632. Std of Reward: 33.443. Training.
[INFO] gewu. Step: 16940000. Time Elapsed: 4664.039 s. Mean Reward: 7661.759. Std of Reward: 68.604. Training.
[INFO] gewu. Step: 16960000. Time Elapsed: 4677.671 s. Mean Reward: 5611.888. Std of Reward: 3165.918. Training.
[INFO] gewu. Step: 16980000. Time Elapsed: 4690.027 s. Mean Reward: 7263.741. Std of Reward: 771.342. Training.
[INFO] gewu. Step: 17000000. Time Elapsed: 4702.667 s. Mean Reward: 7484.952. Std of Reward: 285.833. Training.
[INFO] gewu. Step: 17020000. Time Elapsed: 4715.247 s. Mean Reward: 7639.035. Std of Reward: 91.474. Training.
[INFO] gewu. Step: 17040000. Time Elapsed: 4726.344 s. Mean Reward: 7555.808. Std of Reward: 177.976. Training.
[INFO] gewu. Step: 17060000. Time Elapsed: 4738.798 s. Mean Reward: 7550.319. Std of Reward: 9.339. Training.
[INFO] gewu. Step: 17080000. Time Elapsed: 4752.006 s. Mean Reward: 6911.643. Std of Reward: 1717.295. Training.
[INFO] gewu. Step: 17100000. Time Elapsed: 4764.715 s. Mean Reward: 7581.164. Std of Reward: 159.396. Training.
[INFO] gewu. Step: 17120000. Time Elapsed: 4777.914 s. Mean Reward: 7683.990. Std of Reward: 84.970. Training.
[INFO] gewu. Step: 17140000. Time Elapsed: 4791.444 s. Mean Reward: 5836.416. Std of Reward: 4773.670. Training.
[INFO] gewu. Step: 17160000. Time Elapsed: 4803.150 s. Mean Reward: 7542.133. Std of Reward: 107.650. Training.
[INFO] gewu. Step: 17180000. Time Elapsed: 4815.555 s. Mean Reward: 6640.046. Std of Reward: 2560.167. Training.
[INFO] gewu. Step: 17200000. Time Elapsed: 4826.180 s. Mean Reward: 7496.783. Std of Reward: 72.740. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-17199190.onnx
[INFO] gewu. Step: 17220000. Time Elapsed: 4833.228 s. Mean Reward: 7322.882. Std of Reward: 604.811. Training.
[INFO] gewu. Step: 17240000. Time Elapsed: 4846.263 s. Mean Reward: 6665.952. Std of Reward: 2027.894. Training.
[INFO] gewu. Step: 17260000. Time Elapsed: 4859.432 s. Mean Reward: 6929.921. Std of Reward: 1394.413. Training.
[INFO] gewu. Step: 17280000. Time Elapsed: 4872.040 s. Mean Reward: 7554.631. Std of Reward: 71.847. Training.
[INFO] gewu. Step: 17300000. Time Elapsed: 4884.812 s. Mean Reward: 7557.728. Std of Reward: 100.768. Training.
[INFO] gewu. Step: 17320000. Time Elapsed: 4896.894 s. Mean Reward: 5285.085. Std of Reward: 3619.636. Training.
[INFO] gewu. Step: 17340000. Time Elapsed: 4909.333 s. Mean Reward: 4752.711. Std of Reward: 4842.993. Training.
[INFO] gewu. Step: 17360000. Time Elapsed: 4922.017 s. Mean Reward: 4794.483. Std of Reward: 2984.382. Training.
[INFO] gewu. Step: 17380000. Time Elapsed: 4934.728 s. Mean Reward: 5996.493. Std of Reward: 2306.466. Training.
[INFO] gewu. Step: 17400000. Time Elapsed: 4947.260 s. Mean Reward: 7649.584. Std of Reward: 110.237. Training.
[INFO] gewu. Step: 17420000. Time Elapsed: 4960.382 s. Mean Reward: 7154.992. Std of Reward: 1217.245. Training.
[INFO] gewu. Step: 17440000. Time Elapsed: 4972.704 s. Mean Reward: 7165.867. Std of Reward: 864.837. Training.
[INFO] gewu. Step: 17460000. Time Elapsed: 4985.381 s. Mean Reward: 7500.264. Std of Reward: 413.480. Training.
[INFO] gewu. Step: 17480000. Time Elapsed: 4997.813 s. Mean Reward: 7612.503. Std of Reward: 60.992. Training.
[INFO] gewu. Step: 17500000. Time Elapsed: 5010.102 s. Mean Reward: 7675.940. Std of Reward: 135.838. Training.
[INFO] gewu. Step: 17520000. Time Elapsed: 5022.561 s. Mean Reward: 7609.549. Std of Reward: 59.626. Training.
[INFO] gewu. Step: 17540000. Time Elapsed: 5034.488 s. Mean Reward: 7507.254. Std of Reward: 311.170. Training.
[INFO] gewu. Step: 17560000. Time Elapsed: 5047.351 s. Mean Reward: 7592.462. Std of Reward: 125.374. Training.
[INFO] gewu. Step: 17580000. Time Elapsed: 5059.838 s. Mean Reward: 7644.006. Std of Reward: 102.675. Training.
[INFO] gewu. Step: 17600000. Time Elapsed: 5072.608 s. Mean Reward: 7566.101. Std of Reward: 70.280. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-17599634.onnx
[INFO] gewu. Step: 17620000. Time Elapsed: 5084.931 s. Mean Reward: 6738.315. Std of Reward: 2337.370. Training.
[INFO] gewu. Step: 17640000. Time Elapsed: 5097.849 s. Mean Reward: 7599.651. Std of Reward: 49.159. Training.
[INFO] gewu. Step: 17660000. Time Elapsed: 5104.943 s. Mean Reward: 7611.244. Std of Reward: 83.467. Training.
[INFO] gewu. Step: 17680000. Time Elapsed: 5116.195 s. Mean Reward: 6482.580. Std of Reward: 2275.023. Training.
[INFO] gewu. Step: 17700000. Time Elapsed: 5129.411 s. Mean Reward: 7627.317. Std of Reward: 75.340. Training.
[INFO] gewu. Step: 17720000. Time Elapsed: 5141.078 s. Mean Reward: 7311.999. Std of Reward: 407.167. Training.
[INFO] gewu. Step: 17740000. Time Elapsed: 5153.607 s. Mean Reward: 7569.301. Std of Reward: 69.574. Training.
[INFO] gewu. Step: 17760000. Time Elapsed: 5166.220 s. Mean Reward: 6657.922. Std of Reward: 2387.049. Training.
[INFO] gewu. Step: 17780000. Time Elapsed: 5178.935 s. Mean Reward: 4654.485. Std of Reward: 3370.486. Training.
[INFO] gewu. Step: 17800000. Time Elapsed: 5191.905 s. Mean Reward: 4081.562. Std of Reward: 7803.660. Training.
[INFO] gewu. Step: 17820000. Time Elapsed: 5204.442 s. Mean Reward: 5758.184. Std of Reward: 2197.285. Training.
[INFO] gewu. Step: 17840000. Time Elapsed: 5217.238 s. Mean Reward: 5894.800. Std of Reward: 2699.332. Training.
[INFO] gewu. Step: 17860000. Time Elapsed: 5229.939 s. Mean Reward: 7497.118. Std of Reward: 50.978. Training.
[INFO] gewu. Step: 17880000. Time Elapsed: 5242.420 s. Mean Reward: 7167.354. Std of Reward: 743.506. Training.
[INFO] gewu. Step: 17900000. Time Elapsed: 5254.827 s. Mean Reward: 6960.926. Std of Reward: 1274.737. Training.
[INFO] gewu. Step: 17920000. Time Elapsed: 5266.832 s. Mean Reward: 7461.491. Std of Reward: 63.886. Training.
[INFO] gewu. Step: 17940000. Time Elapsed: 5279.603 s. Mean Reward: 7502.800. Std of Reward: 19.125. Training.
[INFO] gewu. Step: 17960000. Time Elapsed: 5292.219 s. Mean Reward: 7416.297. Std of Reward: 124.202. Training.
[INFO] gewu. Step: 17980000. Time Elapsed: 5304.673 s. Mean Reward: 7419.070. Std of Reward: 39.017. Training.
[INFO] gewu. Step: 18000000. Time Elapsed: 5317.046 s. Mean Reward: 7466.809. Std of Reward: 26.824. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-17999871.onnx
[INFO] gewu. Step: 18020000. Time Elapsed: 5329.161 s. Mean Reward: 6524.725. Std of Reward: 2110.159. Training.
[INFO] gewu. Step: 18040000. Time Elapsed: 5342.288 s. Mean Reward: 7463.840. Std of Reward: 93.292. Training.
[INFO] gewu. Step: 18060000. Time Elapsed: 5355.645 s. Mean Reward: 7250.922. Std of Reward: 360.165. Training.
[INFO] gewu. Step: 18080000. Time Elapsed: 5367.260 s. Mean Reward: 2241.689. Std of Reward: 7262.738. Training.
[INFO] gewu. Step: 18100000. Time Elapsed: 5379.817 s. Mean Reward: 6256.264. Std of Reward: 2463.009. Training.
[INFO] gewu. Step: 18120000. Time Elapsed: 5392.280 s. Mean Reward: 7424.286. Std of Reward: 101.651. Training.
[INFO] gewu. Step: 18140000. Time Elapsed: 5399.345 s. Mean Reward: 5999.302. Std of Reward: 2130.941. Training.
[INFO] gewu. Step: 18160000. Time Elapsed: 5411.405 s. Mean Reward: 5679.919. Std of Reward: 2657.200. Training.
[INFO] gewu. Step: 18180000. Time Elapsed: 5424.334 s. Mean Reward: 7486.912. Std of Reward: 82.016. Training.
[INFO] gewu. Step: 18200000. Time Elapsed: 5437.015 s. Mean Reward: 7435.105. Std of Reward: 29.545. Training.
[INFO] gewu. Step: 18220000. Time Elapsed: 5449.242 s. Mean Reward: 7045.786. Std of Reward: 1144.193. Training.
[INFO] gewu. Step: 18240000. Time Elapsed: 5461.911 s. Mean Reward: 7527.091. Std of Reward: 94.200. Training.
[INFO] gewu. Step: 18260000. Time Elapsed: 5473.883 s. Mean Reward: 7479.120. Std of Reward: 6.547. Training.
[INFO] gewu. Step: 18280000. Time Elapsed: 5486.289 s. Mean Reward: 5485.683. Std of Reward: 2846.681. Training.
[INFO] gewu. Step: 18300000. Time Elapsed: 5499.595 s. Mean Reward: 6636.840. Std of Reward: 2200.755. Training.
[INFO] gewu. Step: 18320000. Time Elapsed: 5512.386 s. Mean Reward: 7543.393. Std of Reward: 76.624. Training.
[INFO] gewu. Step: 18340000. Time Elapsed: 5524.921 s. Mean Reward: 5461.203. Std of Reward: 2164.391. Training.
[INFO] gewu. Step: 18360000. Time Elapsed: 5536.923 s. Mean Reward: 6801.461. Std of Reward: 1853.363. Training.
[INFO] gewu. Step: 18380000. Time Elapsed: 5550.015 s. Mean Reward: 6808.602. Std of Reward: 2260.327. Training.
[INFO] gewu. Step: 18400000. Time Elapsed: 5561.668 s. Mean Reward: 7570.565. Std of Reward: 0.000. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-18399782.onnx
[INFO] gewu. Step: 18420000. Time Elapsed: 5574.160 s. Mean Reward: 6681.295. Std of Reward: 1696.575. Training.
[INFO] gewu. Step: 18440000. Time Elapsed: 5586.840 s. Mean Reward: 6547.565. Std of Reward: 2537.382. Training.
[INFO] gewu. Step: 18460000. Time Elapsed: 5599.538 s. Mean Reward: 5616.059. Std of Reward: 2927.982. Training.
[INFO] gewu. Step: 18480000. Time Elapsed: 5612.150 s. Mean Reward: 7408.402. Std of Reward: 160.286. Training.
[INFO] gewu. Step: 18500000. Time Elapsed: 5624.942 s. Mean Reward: 6904.769. Std of Reward: 1906.797. Training.
[INFO] gewu. Step: 18520000. Time Elapsed: 5637.687 s. Mean Reward: 5682.597. Std of Reward: 3036.680. Training.
[INFO] gewu. Step: 18540000. Time Elapsed: 5650.327 s. Mean Reward: 1708.887. Std of Reward: 5854.546. Training.
[INFO] gewu. Step: 18560000. Time Elapsed: 5662.512 s. Mean Reward: 6582.043. Std of Reward: 2451.491. Training.
[INFO] gewu. Step: 18580000. Time Elapsed: 5669.294 s. Mean Reward: 5857.863. Std of Reward: 2999.537. Training.
[INFO] gewu. Step: 18600000. Time Elapsed: 5682.072 s. Mean Reward: 6187.675. Std of Reward: 2696.701. Training.
[INFO] gewu. Step: 18620000. Time Elapsed: 5693.986 s. Mean Reward: 4013.801. Std of Reward: 5937.252. Training.
[INFO] gewu. Step: 18640000. Time Elapsed: 5706.678 s. Mean Reward: 7502.836. Std of Reward: 181.247. Training.
[INFO] gewu. Step: 18660000. Time Elapsed: 5719.454 s. Mean Reward: 5851.888. Std of Reward: 3123.533. Training.
[INFO] gewu. Step: 18680000. Time Elapsed: 5731.952 s. Mean Reward: 6774.681. Std of Reward: 1236.824. Training.
[INFO] gewu. Step: 18700000. Time Elapsed: 5744.282 s. Mean Reward: 7515.048. Std of Reward: 64.288. Training.
[INFO] gewu. Step: 18720000. Time Elapsed: 5756.761 s. Mean Reward: 7510.653. Std of Reward: 51.926. Training.
[INFO] gewu. Step: 18740000. Time Elapsed: 5768.943 s. Mean Reward: 6046.235. Std of Reward: 3004.338. Training.
[INFO] gewu. Step: 18760000. Time Elapsed: 5781.745 s. Mean Reward: 5097.588. Std of Reward: 3377.916. Training.
[INFO] gewu. Step: 18780000. Time Elapsed: 5794.060 s. Mean Reward: 7404.559. Std of Reward: 108.812. Training.
[INFO] gewu. Step: 18800000. Time Elapsed: 5806.927 s. Mean Reward: 7429.857. Std of Reward: 64.371. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-18799448.onnx
[INFO] gewu. Step: 18820000. Time Elapsed: 5819.483 s. Mean Reward: 7379.882. Std of Reward: 156.667. Training.
[INFO] gewu. Step: 18840000. Time Elapsed: 5832.879 s. Mean Reward: 7152.859. Std of Reward: 767.391. Training.
[INFO] gewu. Step: 18860000. Time Elapsed: 5844.923 s. Mean Reward: 5528.648. Std of Reward: 2945.845. Training.
[INFO] gewu. Step: 18880000. Time Elapsed: 5857.544 s. Mean Reward: 5938.251. Std of Reward: 2930.446. Training.
[INFO] gewu. Step: 18900000. Time Elapsed: 5869.595 s. Mean Reward: 5562.980. Std of Reward: 3440.722. Training.
[INFO] gewu. Step: 18920000. Time Elapsed: 5881.389 s. Mean Reward: 7389.587. Std of Reward: 59.363. Training.
[INFO] gewu. Step: 18940000. Time Elapsed: 5893.956 s. Mean Reward: 7417.115. Std of Reward: 47.040. Training.
[INFO] gewu. Step: 18960000. Time Elapsed: 5906.390 s. Mean Reward: 5496.532. Std of Reward: 2830.906. Training.
[INFO] gewu. Step: 18980000. Time Elapsed: 5919.290 s. Mean Reward: 6388.710. Std of Reward: 2469.414. Training.
[INFO] gewu. Step: 19000000. Time Elapsed: 5931.929 s. Mean Reward: 6931.534. Std of Reward: 1123.873. Training.
[INFO] gewu. Step: 19020000. Time Elapsed: 5944.644 s. Mean Reward: 6867.501. Std of Reward: 1216.364. Training.
[INFO] gewu. Step: 19040000. Time Elapsed: 5951.386 s. Mean Reward: 7417.015. Std of Reward: 29.699. Training.
[INFO] gewu. Step: 19060000. Time Elapsed: 5964.285 s. Mean Reward: 5899.959. Std of Reward: 2620.244. Training.
[INFO] gewu. Step: 19080000. Time Elapsed: 5975.900 s. Mean Reward: 6454.741. Std of Reward: 1241.788. Training.
[INFO] gewu. Step: 19100000. Time Elapsed: 5988.636 s. Mean Reward: 3344.285. Std of Reward: 6310.007. Training.
[INFO] gewu. Step: 19120000. Time Elapsed: 6001.374 s. Mean Reward: 7245.202. Std of Reward: 197.272. Training.
[INFO] gewu. Step: 19140000. Time Elapsed: 6013.657 s. Mean Reward: 7397.521. Std of Reward: 26.223. Training.
[INFO] gewu. Step: 19160000. Time Elapsed: 6026.365 s. Mean Reward: 7376.951. Std of Reward: 103.220. Training.
[INFO] gewu. Step: 19180000. Time Elapsed: 6037.968 s. Mean Reward: 7425.233. Std of Reward: 54.923. Training.
[INFO] gewu. Step: 19200000. Time Elapsed: 6051.141 s. Mean Reward: 7383.629. Std of Reward: 249.905. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-19199609.onnx
[INFO] gewu. Step: 19220000. Time Elapsed: 6062.442 s. Mean Reward: 6516.670. Std of Reward: 2159.772. Training.
[INFO] gewu. Step: 19240000. Time Elapsed: 6075.262 s. Mean Reward: 4939.061. Std of Reward: 2884.112. Training.
[INFO] gewu. Step: 19260000. Time Elapsed: 6088.825 s. Mean Reward: 7272.312. Std of Reward: 215.666. Training.
[INFO] gewu. Step: 19280000. Time Elapsed: 6100.218 s. Mean Reward: 7354.134. Std of Reward: 31.734. Training.
[INFO] gewu. Step: 19300000. Time Elapsed: 6113.257 s. Mean Reward: 6571.440. Std of Reward: 2210.710. Training.
[INFO] gewu. Step: 19320000. Time Elapsed: 6125.735 s. Mean Reward: 5986.488. Std of Reward: 2566.666. Training.
[INFO] gewu. Step: 19340000. Time Elapsed: 6138.708 s. Mean Reward: 7329.453. Std of Reward: 108.975. Training.
[INFO] gewu. Step: 19360000. Time Elapsed: 6151.276 s. Mean Reward: 6446.534. Std of Reward: 2411.189. Training.
[INFO] gewu. Step: 19380000. Time Elapsed: 6163.625 s. Mean Reward: 6171.837. Std of Reward: 2583.777. Training.
[INFO] gewu. Step: 19400000. Time Elapsed: 6175.813 s. Mean Reward: 6660.276. Std of Reward: 1094.104. Training.
[INFO] gewu. Step: 19420000. Time Elapsed: 6188.362 s. Mean Reward: 7398.232. Std of Reward: 34.077. Training.
[INFO] gewu. Step: 19440000. Time Elapsed: 6200.736 s. Mean Reward: 7392.866. Std of Reward: 43.342. Training.
[INFO] gewu. Step: 19460000. Time Elapsed: 6207.863 s. Mean Reward: 5917.266. Std of Reward: 2952.149. Training.
[INFO] gewu. Step: 19480000. Time Elapsed: 6219.458 s. Mean Reward: 3895.637. Std of Reward: 5016.054. Training.
[INFO] gewu. Step: 19500000. Time Elapsed: 6231.949 s. Mean Reward: 6990.437. Std of Reward: 713.270. Training.
[INFO] gewu. Step: 19520000. Time Elapsed: 6244.629 s. Mean Reward: 5862.490. Std of Reward: 2973.079. Training.
[INFO] gewu. Step: 19540000. Time Elapsed: 6257.611 s. Mean Reward: 7469.678. Std of Reward: 68.951. Training.
[INFO] gewu. Step: 19560000. Time Elapsed: 6270.393 s. Mean Reward: 5748.116. Std of Reward: 1554.305. Training.
[INFO] gewu. Step: 19580000. Time Elapsed: 6282.899 s. Mean Reward: 6765.810. Std of Reward: 1676.801. Training.
[INFO] gewu. Step: 19600000. Time Elapsed: 6295.168 s. Mean Reward: 6477.473. Std of Reward: 2397.263. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-19599328.onnx
[INFO] gewu. Step: 19620000. Time Elapsed: 6307.839 s. Mean Reward: 7394.247. Std of Reward: 21.492. Training.
[INFO] gewu. Step: 19640000. Time Elapsed: 6319.807 s. Mean Reward: 7409.273. Std of Reward: 85.368. Training.
[INFO] gewu. Step: 19660000. Time Elapsed: 6332.471 s. Mean Reward: 6516.613. Std of Reward: 1358.130. Training.
[INFO] gewu. Step: 19680000. Time Elapsed: 6345.273 s. Mean Reward: 2363.978. Std of Reward: 8626.309. Training.
[INFO] gewu. Step: 19700000. Time Elapsed: 6356.802 s. Mean Reward: 4047.751. Std of Reward: 3425.321. Training.
[INFO] gewu. Step: 19720000. Time Elapsed: 6369.393 s. Mean Reward: 6410.186. Std of Reward: 1965.984. Training.
[INFO] gewu. Step: 19740000. Time Elapsed: 6382.580 s. Mean Reward: 5756.792. Std of Reward: 2901.428. Training.
[INFO] gewu. Step: 19760000. Time Elapsed: 6394.787 s. Mean Reward: 5963.594. Std of Reward: 1900.832. Training.
[INFO] gewu. Step: 19780000. Time Elapsed: 6406.860 s. Mean Reward: 5814.098. Std of Reward: 2242.048. Training.
[INFO] gewu. Step: 19800000. Time Elapsed: 6419.641 s. Mean Reward: 7241.996. Std of Reward: 382.071. Training.
[INFO] gewu. Step: 19820000. Time Elapsed: 6432.084 s. Mean Reward: 6860.187. Std of Reward: 1017.515. Training.
[INFO] gewu. Step: 19840000. Time Elapsed: 6444.789 s. Mean Reward: 7453.436. Std of Reward: 48.440. Training.
[INFO] gewu. Step: 19860000. Time Elapsed: 6451.835 s. Mean Reward: 7269.826. Std of Reward: 343.084. Training.
[INFO] gewu. Step: 19880000. Time Elapsed: 6464.941 s. Mean Reward: 6433.353. Std of Reward: 2038.925. Training.
[INFO] gewu. Step: 19900000. Time Elapsed: 6478.352 s. Mean Reward: 5535.952. Std of Reward: 2544.286. Training.
[INFO] gewu. Step: 19920000. Time Elapsed: 6489.706 s. Mean Reward: 6537.033. Std of Reward: 2476.751. Training.
[INFO] gewu. Step: 19940000. Time Elapsed: 6502.408 s. Mean Reward: 6895.301. Std of Reward: 1316.098. Training.
[INFO] gewu. Step: 19960000. Time Elapsed: 6514.967 s. Mean Reward: 7514.332. Std of Reward: 219.757. Training.
[INFO] gewu. Step: 19980000. Time Elapsed: 6527.230 s. Mean Reward: 5960.319. Std of Reward: 2848.877. Training.
[INFO] gewu. Step: 20000000. Time Elapsed: 6539.863 s. Mean Reward: 5621.945. Std of Reward: 2913.801. Training.
[INFO] Exported results\ztest1.0\gewu\gewu-19999403.onnx
[INFO] Exported results\ztest1.0\gewu\gewu-20000403.onnx
[INFO] Copied results\ztest1.0\gewu\gewu-20000403.onnx to results\ztest1.0\gewu.onnx.