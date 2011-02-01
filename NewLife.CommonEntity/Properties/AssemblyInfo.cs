﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的常规信息通过以下
// 特性集控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("通用实体库")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("新生命开发团队")]
[assembly: AssemblyProduct("NewLife.CommonEntity")]
[assembly: AssemblyCopyright("Copyright © 新生命开发团队 2002~2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 使此程序集中的类型
// 对 COM 组件不可见。如果需要从 COM 访问此程序集中的类型，
// 则将该类型上的 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("6affe219-9235-49dc-8032-a0dc9f10f887")]

// 程序集的版本信息由下面四个值组成:
//
//      主版本
//      次版本 
//      内部版本号
//      修订号
//
// 可以指定所有这些值，也可以使用“内部版本号”和“修订号”的默认值，
// 方法是按如下所示使用“*”:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.5.*")]
[assembly: AssemblyFileVersion("1.5.2011.0117")]

/*
 * v1.5.2011.0117   增加表单页基类EntityForm
 * 
 * v1.4.2011.0110   Edit:修改WebPageBase中的一些验证权限和输出执行时间的行为
 *                  Fixed:修改各个实体类中存在的BUG
 * 
 * v1.3.2010.1220   增加统计和附件实体类
 *                  修改角色和菜单实体，增加操作权限项，细分添加、修改、删除等权限
 *                  优化各个实体类，增加写日志的功能（通过接口和HttpState调用管理员的写日志功能）
 *                  Role中增加方法ClearRoleMenu，清理无效的权限项，由Role静态构造函数调用
 * 
 * v1.2.2010.1018   修改地区实体和菜单实体，增加实体树的操作
 * 
 * v1.1.2010.0909   再次抽象管理员实体和角色实体，各增加一层泛型基类
 *                  增加常用页面基类WebPageBase，同时增加一个指定了管理员类的泛型基类。支持输出页面执行时间和页面权限验证
 * 
 * v1.0.2010.0903   创建通用实体库
 *
**/