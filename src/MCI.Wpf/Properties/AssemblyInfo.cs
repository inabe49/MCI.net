﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Markup;

// アセンブリに関する一般情報は以下の属性セットをとおして制御されます。
// アセンブリに関連付けられている情報を変更するには、
// これらの属性値を変更してください。
[assembly: AssemblyTitle("MCI.Wpf")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Miharu Communications Inc.")]
[assembly: AssemblyProduct("MCI.Wpf")]
[assembly: AssemblyCopyright("Copyright (C) Miharu Communications Inc. 2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// ComVisible を false に設定すると、その型はこのアセンブリ内で COM コンポーネントから
// 参照不可能になります。COM からこのアセンブリ内の型にアクセスする場合は、
// その型の ComVisible 属性を true に設定してください。
[assembly: ComVisible(false)]

// 次の GUID は、このプロジェクトが COM に公開される場合の、typelib の ID です
[assembly: Guid("8f07e85f-6246-4b18-99b7-293aa9897d7c")]

// アセンブリのバージョン情報は、以下の 4 つの値で構成されています:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// すべての値を指定するか、下のように '*' を使ってビルドおよびリビジョン番号を
// 既定値にすることができます:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.9.6.0")]
[assembly: AssemblyInformationalVersion("0.9.6.0")]
[assembly: AssemblyFileVersion("0.9.6.0")]


// WPF 用の名前空間の登録
[assembly: XmlnsDefinition("http://schemas.miharu.co.jp/cslibs/2017/wpf", "Miharu.Wpf.Behaviors")]
