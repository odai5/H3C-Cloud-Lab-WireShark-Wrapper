# H3C-Cloud-Lab-WireShark-Wrapper
HCL原版程序抓包调用WireShark只能查看静态内容，参考GNS3调用tail再pipe到WireShark的方法，通过C#和cmd batch实现了一个外挂程序
使得我们能够实时查看实验中产生的数据包内容。

wireshark.exe可以放置在任何路径，wireshark.bat放置在HCL的安装目录比如：C:\Program Files (x86)\HCL

额外需要准备的程序是gnu工具集里的tail.exe，因为GNS3里有，所以我提供的bat脚本中引用的是GNS3的安装路径。

以上都准备妥当后，启动HCL，点击齿轮配置WireShark路径指向下载到的wireshark.exe即可。

https://zhuanlan.zhihu.com/p/59962760
