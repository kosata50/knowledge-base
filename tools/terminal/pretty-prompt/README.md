# Pretty prompt

Example:
![image](https://user-images.githubusercontent.com/9049765/159161296-98d95946-935b-4906-b6a7-6d1fd18010ae.png)

Instructions: 
- https://www.hanselman.com/blog/how-to-make-a-pretty-prompt-in-windows-terminal-with-powerline-nerd-fonts-cascadia-code-wsl-and-ohmyposh
- https://docs.microsoft.com/en-us/windows/terminal/tutorials/powerline-setup

## Install

``` ps
Install-Module posh-git -Scope CurrentUser
Install-Module oh-my-posh -Scope CurrentUser
```


### Profile

`notepad $PROFILE`

``` ps
Import-Module posh-git
Import-Module oh-my-posh
Set-PoshPrompt -Theme paradox
```

Fix czech characters:
``` ps
$env:LC_ALL = 'C.UTF-8'
```

### Font

Cascadia Code: https://github.com/microsoft/cascadia-code/releases

Steps:
1. Install `Cascadia Code PL` to system wide fonts

