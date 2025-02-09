﻿using System.Threading.Tasks;
using System.Windows;
using Wox.Plugin;

namespace Community.PowerToys.Run.Plugin.SVGL;

public class Utils
{
    private static readonly MyApiClients _apiClient = new MyApiClients();

    public static bool CopyToClipboard(string value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            Clipboard.SetText(value);
            return true;
        }
        return false;
    }

    public static bool CopySVGContent(string svg)
    {
        //var apiClient = new MyApiClients();
        var content = Task.Run(async () => await _apiClient.GetSVGContent(svg)).Result;
        CopyToClipboard(content);
        return true;
    }

    public static ContextMenuResult GetContextMenuResult(IGetContextMenuResult args)
    {
        return new ContextMenuResult
        {
            PluginName = "SVGL",
            Title = args.Title,
            FontFamily = "Segoe Fluent Icons,Segoe MDL2 Assets",
            Glyph = args.Glyph,
            AcceleratorKey = args.AcceleratorKey,
            AcceleratorModifiers = args.AcceleratorModifiers,
            //Action = context => args.CustomAction != null ? args.CustomAction(context) : CopySVGContent(args.CopyContent)
            Action = context => args.CustomAction?.Invoke(context) ?? CopySVGContent(args.CopyContent)
        };
    }
}