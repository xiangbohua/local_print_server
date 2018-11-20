
###打印服务
---
最近公司需要在Web页面上打印文件，还要直接连接打印机，为此尝试了很多种方案，IE插件、文件schema、Java Applet等方案。想来想去上面的方案技术上面都不是很熟悉。后来突然冒出来一个方案：
写一个桌面程序，内建一个HTTP Server，当收到请求之后将数据发送到打印机直接打印，这样文件生成发生在客户端，可以直接连接打印机，而且服务器不需要生成文件，速度较快。
使用方式为：
1. 在VS中设计好需要生成的模版
2. 继承一个类用来生成PDF文件
3. 启动程序（会打开一个设定的端口）
4. 将报表需要的数据post发送到打印机

最后程序的功能大概有：
- 打印文件
- 指定打印顺序
- 选择是否立即发送到打印机（选择否时仅生成PDF文件）(~~这算哪门子功能~~)
- 统计任务信息（~~这算哪门子功能~~）
- 设置打印机（~~这算哪门子功能~~）
- 输出日志（~~这算哪门子功能~~）

请求打印时的POST请求：
```
{
    "code":200,
    "msg":"",
    "data":{
        "0":{
            "file_name":"81612232122018414",
            "print_interval":5,
            "print_type":"DeliveryOrderModel",
            "delivery_no":"81612232122018414",
            "waybill_sort":16,
            "created":"2016-12-23",
            "related_no":"1612232106364106"
            
        }
    }
}
```
其中data内的：
- file_name：本地需要保存的文件名称
- print_interval：顺序打印时没张打印的间隔（单位为秒）
- print_type：字符串指明打印程序内模版的名称
- 其他：模版需要的数据

需要实现的类：
`ReportTemplates.Models.PrintModel`

需要设计的模版：
```
public partial class ProductPackLabe53Other : Telerik.Reporting.Report
{
}
```

为了实现上述效果需要解决几个问题：
- 如何搭建HTTP Server？
- 打印数据的生成？
- 如何实现打印模版？
- 如何发送到打印机？

后来查了一些资料一次解决了上面的问题。HTTP Server的实现，有很多博客作者已经实现了，我选择了其中一个直接使用了，但是我忘记是谁的了。
***如果作者看到这个使用并认为有问题可以直接和我联系***；
第二个问题其实不算问题，因为每个业务数据从哪里来都是和业务有关的，这里要说的其实是数据以什么格式传送到打印程序。这个打印小程序即然使用HTTP Server，那么数据肯定是通过JSON传递的啦。
第三个问题解决方案也很多，我用过Jasper的社区版，使用Jasper Studio设计模版然后使用PHPJasper来直接生成PDF文件。但是这个地方使用的另外Terlerik公司的报表库，这个库能直接在VS里面设计模版，C#使用起来比较方便。
最后一个问题，直接使用Process打开文件，并且传递一个print参数给进程，即可自动将数据发送到打印机。
*发送打印机是调取PDF打开程序，打开PDF时传递一个print参数，我使用的Adobe Pdf Reader。没有安装PDF打开软件，或者安装其他软件有可能无法直接发送到打印机*
**打印机不会根据收到打印请求的顺序依此打印，所以没有办法保证打印的顺序和收到请求的顺序严格一致，这在需要保证按照顺序打印的场景实际上会有些问题，因此这个打印程序内部使用一个队列，每次打印一张等待一定时间，这样勉强能够按照顺序打印（不能绝对保证，和打印机有关，不知大佬有没有解决方案）**
发送到打印机代码：
```
ProcessStartInfo info = new ProcessStartInfo();info.Verb = "print";
Process p = new Process();
info.FileName = shortFile;
info.CreateNoWindow = true;
p.StartInfo.Arguments = this.selectedPrinterName;
info.WindowStyle = ProcessWindowStyle.Hidden;
p.StartInfo = info;
p.Start();
p.WaitForInputIdle();
```
需要改进的地方：
- 
- 模版在客户端编译，每次新增模版或者修改模版时都要重新分发给用户，可以通过自动更新来弥补
- 一次打印多张并且需要顺序打印的时候，只能通过打印一张等待一定时间的方式，这个等待时间不好设置，和打印机打印速度有关，长了会浪费等待时间，短了不能顺序打印
- 目前不能自定义端口
- 依赖PDF打印软件，才能发送到打印机
- 界面太丑（朋友指出典型的面向程序员界面，好像是😯）
- 其他？

以后再增加功能吧