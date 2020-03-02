---
title: Installation
menu_order: 2
---

# Ionide-vim - Installation

## Requirements

* Neovim or Vim 8.0+ - Python support is not required as of now. This may or may not change in the future.
* [.NET Core SDK](https://dotnet.microsoft.com/download) - required to run FsAutoComplete
* [LanguageClient-neovim](https://github.com/autozimu/LanguageClient-neovim) - LSP client used to communicate with FsAutoComplete
* [fzf](https://github.com/junegunn/fzf) (optional) -Optional dependency of LanguageClient-neovim, provides multi-entry selection UI

## Getting Started

### 1. Install [LanguageClient-neovim](https://github.com/autozimu/LanguageClient-neovim)

Refer to [their INSTALL.md](https://github.com/autozimu/LanguageClient-neovim/blob/next/INSTALL.md).

### 2. Install Ionide-vim

#### Installing with your plugin manager

##### [vim-plug](https://github.com/junegunn/vim-plug)

~~~.vim
Plug 'ionide/Ionide-vim', {
      \ 'do':  'make fsautocomplete',
      \}
~~~

##### [dein.vim](https://github.com/Shougo/dein.vim)

~~~.vim
call dein#add('ionide/Ionide-vim', {
    \ 'build': 'make fsautocomplete',
    \ })
~~~

#### Installing manually

Clone Ionide-vim to some runtimepath and run `make fsautocomplete`.

#### Installing on Windows

Run `install.cmd`.