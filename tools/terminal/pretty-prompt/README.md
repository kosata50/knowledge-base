# Pretty prompt

Example:
![image](https://user-images.githubusercontent.com/9049765/159161296-98d95946-935b-4906-b6a7-6d1fd18010ae.png)

References: 
- https://www.hanselman.com/blog/how-to-make-a-pretty-prompt-in-windows-terminal-with-powerline-nerd-fonts-cascadia-code-wsl-and-ohmyposh
- https://docs.microsoft.com/en-us/windows/terminal/tutorials/powerline-setup

## Install

Install PoweShell modules containing main magic fro pretty prompt.

``` ps
Install-Module posh-git -Scope CurrentUser
Install-Module oh-my-posh -Scope CurrentUser
```


### Profile

Update you PowerShell script to apply this setting each time PowerShell is started.

`notepad $PROFILE`

``` ps
Import-Module posh-git
Import-Module oh-my-posh
Set-PoshPrompt -Theme thecyberden
```

Fix czech characters:
``` ps
$env:LC_ALL = 'C.UTF-8'
```

## Select theme

You can choose from various themes with ability to show preview for each of them: https://ohmyposh.dev/docs/themes

### Font

In order to see all themes correctly you need to download special font package. Currenly reccommended are [Nerd Fonts](https://www.nerdfonts.com/).

Instructions:
- https://ohmyposh.dev/docs/config-fonts

Recommended font:
- `Meslo LGM NF`
- Download link - https://github.com/ryanoasis/nerd-fonts/releases/download/v2.1.0/Meslo.zip

Steps to follow:

1. Install font to Windows
1. Set font to your terminal application (e.g. Windows Terminal)
```json
{
    "profiles":
    {
        "defaults":
        {
            "font":
            {
                "face": "MesloLGM NF"
            }
        }
    }
}
```