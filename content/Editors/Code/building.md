---
title: Building your code
menu_order: 5
---

# Building your code

### Smart build configurations

Ionide generates VSCode [Tasks](https://code.visualstudio.com/docs/editor/tasks) for building, cleaning, and re-building every project in your workspace, as well as for the entire solution (if you have one). These tasks can be used as-is, or you can easily use them as the start of your own custom configurations.

To explicitly run one of the new tasks, first select the `Tasks: Run Task` command from the Command Palette (which can be invoked by pressing `Ctrl/Cmd+Shift+P`). 

<img class="png" src="/static/images/vscode-run-tasks.png" />

Then, choose the `msbuild` category:

<img class="png" src="/static/images/vscode-task-category.png" />

Finally, choose the task you want to run from the list:

<img class="png" src="/static/images/vscode-msbuild-tasks.png" />

### Defaults

By default, using `Ctrl/Cmd+Shift+B` will run the 'build' task for the current project.

### Integration with debugging

All generated tasks can be used as `preLaunchTask`s for your own launch/debug configurations, which can really help for ensuring that the most recent build is always used when debugging or running your own code. See [running](/docs/running) for more information about this.
