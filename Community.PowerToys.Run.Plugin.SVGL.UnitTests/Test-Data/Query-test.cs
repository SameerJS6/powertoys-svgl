﻿using System.Collections.Generic;
using System.Windows.Input;
using Wox.Plugin;


namespace Community.PowerToys.Run.Plugin.SVGL.UnitTests;

public static class QueryTestData
{
    public static List<Result> GoogleData()
    {
        var results = new List<Result>
        {
            new()
            {
                Title = "Google",
                SubTitle = TestContants.expectedCategoryString("Google").ToString(),
                IcoPath = "Images\\svgl.dark.png",
                Score = 100,
                ContextData = new Svgl
                {
                    Id = 1,
                    Title = "Google",
                    Category = TestContants.expectedCategoryString("Google"),
                    Route = TestContants.expectedRouteString("https://svgl.app/library/google.svg"),
                    Wordmark = TestContants.expectedWordmarkString("https://svgl.app/library/google-wordmark.svg"),
                    Url = "https://google.com"
                },
                Action = _ => true
            },
            new()
            {
                Title = "Google Drive",
                SubTitle = TestContants.expectedCategoryString("Google").ToString(),
                IcoPath = "Images\\svgl.dark.png",
                Score = 99,
                ContextData = new Svgl
                {
                    Id = 1,
                    Title = "Google",
                    Category = TestContants.expectedCategoryString("Google"),
                    Route = TestContants.expectedRouteString("https://svgl.app/library/google.svg"),
                    Wordmark = TestContants.expectedWordmarkString("https://svgl.app/library/google-wordmark.svg"),
                    Url = "https://google.com"
                },
                Action = _ => true
            },
            new()
            {
                Title = "Google Idx",
                SubTitle = $"Software, {TestContants.expectedCategoryString("Google").ToString()}",
                IcoPath = "Images\\svgl.dark.png",
                Score = 98,
                ContextData = new Svgl
                {
                    Id = 1,
                    Title = "Google",
                    Category = TestContants.expectedCategoryString("Google"),
                    Route = TestContants.expectedRouteString("https://svgl.app/library/google.svg"),
                    Wordmark = TestContants.expectedWordmarkString("https://svgl.app/library/google-wordmark.svg"),
                    Url = "https://google.com"
                },
                Action = _ => true
            },
            new()
            {
                Title = "Google PaLM",
                SubTitle = $"AI, {TestContants.expectedCategoryString("Google").ToString()}",
                IcoPath = "Images\\svgl.dark.png",
                Score = 97,
                ContextData = new Svgl
                {
                    Id = 1,
                    Title = "Google",
                    Category = TestContants.expectedCategoryString("Google"),
                    Route = TestContants.expectedRouteString("https://svgl.app/library/google.svg"),
                    Wordmark = TestContants.expectedWordmarkString("https://svgl.app/library/google-wordmark.svg"),
                    Url = "https://google.com"
                },
                Action = _ => true
            },
            new()
            {
                Title = "Google Colaboratory",
                SubTitle = $"{TestContants.expectedCategoryString("Google").ToString()}, Software",
                IcoPath = "Images\\svgl.dark.png",
                Score = 96,
                ContextData = new Svgl
                {
                    Id = 1,
                    Title = "Google",
                    Category = TestContants.expectedCategoryString("Google"),
                    Route = TestContants.expectedRouteString("https://svgl.app/library/google.svg"),
                    Wordmark = TestContants.expectedWordmarkString("https://svgl.app/library/google-wordmark.svg"),
                    Url = "https://google.com"
                },
                Action = _ => true
            }
        };

        return results;
    }

    public static List<Result> FlareData()
    {
        var results = new List<Result>
        {
            new()
            {
                Title = "Cloudflare Workers",
                SubTitle = TestContants.expectedCategoryString("Software").ToString(),
                IcoPath = "Images\\svgl.dark.png",
                Score = 100,
                ContextData = new Svgl
                {
                    Id = 179,
                    Title = "Cloudflare Workers",
                    Category = TestContants.expectedCategoryString("Software"),
                    Route = TestContants.expectedRouteString("https://svgl.app/library/cloudflare-workers.svg"),
                    Url = "https://workers.cloudflare.com/"
                },
                Action = _ => true
            },
            new()
            {
                Title = "Cloudflare",
                SubTitle = TestContants.expectedCategoryString("Software").ToString(),
                IcoPath = "Images\\svgl.dark.png",
                Score = 99,
                ContextData = new Svgl
                {
                    Id = 180,
                    Title = "Cloudflare",
                    Category = TestContants.expectedCategoryString("Software"),
                    Route = TestContants.expectedRouteString("https://svgl.app/library/cloudflare.svg"),
                    Url = "https://www.cloudflare.com/"
                },
                Action = _ => true
            }
        };

        return results;
    }

    public static List<Result> NoResultFoundData(string query)
    {
        var results = new List<Result>
        {
            new()
            {
                Title = TestContants.NoResultFoundMessage,
                SubTitle = TestContants.NoResultFoundSubTitle(query),
                IcoPath = "Images\\svgl.dark.png",
                Score = 100,
                Action = _ => false
            },
            new()
            {
                Title = TestContants.RequestLogo,
                SubTitle = "Request a Logo on SVGL's Repository",
                IcoPath = "Images\\svgl.dark.png",
                Action = _ => true
            },
            new()
            {
                Title = TestContants.SubmitLogo,
                SubTitle = "Submit a Logo on SVGL's Repository",
                IcoPath = "Images\\svgl.dark.png",
                Action = _ => true
            }
        };
        return results;
    }

    public static List<Svgl> GetSampleSvgs()
    {
        return
        [
            // Case 1: Simple case - ThemeString + CategoryString
            new Svgl
            {
                Id = 1,
                Title = "Google",
                Category = new CategoryString("Technology"),
                Route = new ThemeString("google.svg"),
                Wordmark = new ThemeString("google-wordmark.svg"),
                Url = "https://google.com"
            },

            // Case 2: Theme with light/dark + Array of categories
            new Svgl
            {
                Id = 2,
                Title = "Vercel",
                Category = new CategoryArray(["Hosting", "Development"]),
                Route = new ThemeObject(new SvgThemes
                {
                    Light = "vercel.svg",
                    Dark = "vercel-dark.svg"
                }),
                Wordmark = new ThemeObject(new SvgThemes
                {
                    Light = "vercel-wordmark.svg",
                    Dark = "vercel-wordmark-dark.svg"
                }),
                Url = "https://vercel.com"
            },

            // Case 3: Mixed theme types + single category
            new Svgl
            {
                Id = 3,
                Title = "GitHub",
                Category = new CategoryString("Development"),
                Route = new ThemeObject(new SvgThemes
                {
                    Light = "github.svg",
                    Dark = "github-dark.svg"
                }),
                Wordmark = new ThemeString("github-wordmark.svg"),
                Url = "https://github.com"
            }
        ];
    }


    public static Svgl GetSampleSVGContextData()
    {
        return
            new Svgl()
            {
                Id = 2,
                Title = "Vercel",
                Category = new CategoryArray(["Hosting", "Development"]),
                Route = new ThemeObject(new SvgThemes
                {
                    Light = "vercel.svg",
                    Dark = "vercel-dark.svg"
                }),
                Wordmark = new ThemeObject(new SvgThemes
                {
                    Light = "vercel-wordmark.svg",
                    Dark = "vercel-wordmark-dark.svg"
                }),
                Url = "https://vercel.com"
            }
            ;
    }

    public static Svgl GetDefaultSVGContextData()
    {
        return new Svgl
        {
            Id = 3,
            Title = "GitHub",
            Category = new CategoryString("Development"),
            Route = new ThemeString("github.svg"),
            Url = "https://github.com"
        };
    }

    public static List<ContextMenuResult> GetDefaultContextMenu()
    {
        return
        [
            new ContextMenuResult
            {
                Title = Constants.CopySvgLogoMessage,
                Glyph = "\xE8C8",
                AcceleratorKey = Key.Enter
            }
        ];
    }

    public static List<ContextMenuResult> GetAllContextMenu()
    {
        return
        [
            new ContextMenuResult
            {
                Title = Constants.CopyLightThemeSvgLogoMessage,
                Glyph = "\xE706",
                AcceleratorKey = Key.Enter
            },
            new ContextMenuResult
            {
                Title = Constants.CopyDarkThemeSvgLogoMessage,
                Glyph = "\xE708",
                AcceleratorKey = Key.Enter,
                AcceleratorModifiers = ModifierKeys.Control
            },
            new ContextMenuResult
            {
                Title = Constants.CopyLightThemeSvgWordmarkMessage,
                Glyph = "\xE8D2",
                AcceleratorKey = Key.Enter,
                AcceleratorModifiers = ModifierKeys.Shift
            },
            new ContextMenuResult
            {
                Title = Constants.CopyDarkThemeSvgWordmarkMessage,
                Glyph = "\xE8D3",
                AcceleratorKey = Key.Enter,
                AcceleratorModifiers = ModifierKeys.Control | ModifierKeys.Shift
            }
        ];
    }
}