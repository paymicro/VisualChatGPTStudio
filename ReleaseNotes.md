﻿## Release Notes 📜

### 5.5.0

- Added the "Apply" button in the Turbo Chat window. This button allows you to apply the changes suggested by the AI directly to the code editor, without needing to copy and paste the response manually.
- Update Turbo Chat to support mermaid diagrams rendering. Necessary Visual Studio 2022 version 17.14.16 or higher.
- Fixed the long words that break the layout in the Turbo Chat window.
- Improved set scroll position when new messages are added in the Turbo Chat window.
- Improved feedback messages when API calls fail.
- Fixed Turbo Chat invisible on Visual Studio 2019.
- Fixed crash on Turbo Chat when double click on empty space. Thanks to [@paymicro](https://github.com/paymicro).
- Added reasoning block separation on Turbo Chat when the response contains `<think>` blocks. Thanks to [@paymicro](https://github.com/paymicro).
- Added the new extension option 'Use Enter to send request in chat', where if true, pressing Enter will send the request in chat instead of using Ctrl+Enter. Thanks to [@paymicro](https://github.com/paymicro).

### 5.4.1

- Added ApiVersion override for Open AI Compatible API. Thanks [IH8E](https://github.com/IH8E).
- Fixed the Turbo Chat window that was overlapping the native Visual Studio windows.

### 5.4.0

- Add the new computer-use beta feature on Turbo Chat.
- Improved Turbo Chat formatting.
- Replaced the WebBrowser component (based on Internet Explorer) with WebView2 (based on Edge) in the Turbo Chat window. This ensures better display and responsiveness, as well as the ability to copy text using CTRL+C.
- Fixed streaming responses on code editor.

### 5.3.0

- This version features a faster, lighter, and more responsive turbo chat interface with improved usability.

### 5.2.1

- Copilot feature predictions enhancement. Thanks [Asafima](https://github.com/Asafima).
- Added error handling for when the API returns status code 429 and requests to try again after a specific amount of time. In this case, the extension will wait for that time before making a new request automatically.

### 5.2.0

- The Copilot feature has been fixed to work with Visual Studio 2022 version 17.14.x.
- Due to the need to ensure compatibility of the Copilot feature with Visual Studio, starting from this version, Visual Studio version 17.14 or higher is required.

### 5.1.2

- Improvements added so that screen reading tools can read the commands.
- More improvements in navigating controls in the Turbo Chat window using the keyboard.

### 5.1.1

- Improvements in navigating controls in the Chat and Turbo Chat window using the keyboard.
- Changed the shortcut to reference files and/or methods in request fields from "#" to "@" to avoid match with the word "c#" which may occasionally be used.

### 5.1.0

- Due to the fact that OpenAI is always updating the list of models, and also because other LLMs may have their own models, I am setting the "Model" parameter in the extension options as an open field for editing. And because of that, the parameter "Model Language Override" is not more necessary. See the available models [here](https://platform.openai.com/docs/models).

### 5.0.0

- Added the ability to request the AI to call REST and SOAP APIs on one or more endpoints through the Turbo Chat window.
- Fixed git-worktree repository detection logic (thanks [Kryeker](https://github.com/Kryeker)).
- Added the new 'Azure URL Override' parameter on options, to manually define the Azure OpenAI connection URL instead of using 'Resource Name', 'Deployment Name', and 'API Version'. This is useful for custom endpoints.
- Added the new 'Completion Base API URL Override' parameter on options, to possibility change the Completion API connection URL if you wish to do so for some reason, for example use a custom LLM deployment specific only for the Completions.
- The visualization of the results of a query performed by the SQL Agent has been fixed when many records are returned.

### 4.0.0

- Added the ability to request the AI to execute SQL Server scripts on one or more databases through the Turbo Chat window.
- Refactoring to remove the dependency on the library [OpenAI-API-dotnet](https://github.com/OkGoDoIt/OpenAI-API-dotnet), and add its source code as a project in the Solution, making it possible to customize it.

### 3.4.0

- Added the possibility to attach images to the requests (not all models accept images).
- Added to the list of models the o1 and o3-mini models.
- Improvements in the functionality of referencing files and methods in requests.

### 3.3.0

- Shortcuts have been added for the predefined commands, as well as the ability to reference files and/or methods directly in the request fields.
- Improvements in the visualization of fields for the Tool Window.
- Added a filter in the Solution Context window.

### 3.2.3

- Adjustment to prevent Markdown tags from being added to the code editor when using the "Add Comments" command.

### 3.2.2

- Limited to version 17.12.0 or above for Visual Studio 2022 due compatibility.

### 3.2.1

- Fixed the execution of commands by holding the SHIFT key to send the responses to the Tool Window (the "Please, open the tool window first" error).

### 3.2.0

- Added the possibility to use completion API instead of Chat API. Thanks [karburator](https://github.com/karburator) for the collaboration.
- Fixed the issue preventing the extension from loading correctly starting from version 17.12.0 of Visual Studio 2022.
- Fixed the 'Stream was not readable' bug.
- Fixed an issue where an empty value was sent in the Stop Sequences parameter when it was not defined in the extension options. This caused some models to not respond correctly.

### 3.1.0

- Added the possibility to use your Microsoft Account to authenticate to the Azure Open AI Service through Entra ID.

### 3.0.4

- Bug fixes and adjusts.

### 3.0.3

- The copilot functionality that wasn't working has been fixed.
- The behavior that caused the scroll to move automatically when clicking with the mouse to select text has been removed from the Turbo Chat window.

### 3.0.2

- Now the Model parameters are optional.

### 3.0.1

- The icons in Turbo Chat that were removed incorrectly have been restored.

### 3.0

- Added the Copilot functionality (only for Visual Studio 2022).
- Now the gpt-4o-mini model is the default model for OpenAI API.
- Many improvements and fixes on Turbo Chat window.

### 2.8.2

- Added validation to prevent removal of default commands.
- Added support for the new gpt-4o-mini model.

### 2.8.1

- Updated `Ask Anything` command to send `Tool Window System Message` as System Message.
- Some fixes to avoid errors when doing Code Review.
- Now on Code Review the progress bar shows the real progress.
- Fixed the Code Review item hyper link.
- Now the API responses lines breaks in code editor will be normalized to avoid mixing line breaks patterns. 
- Fixed the command "Generate Git Changes Comment" to ensure consider only pending changes.

### 2.8.0

- Added the new option `Tool Window System Message` in the Extension's Options to possibility customizing the System Message for the `Tool Window` chat requests.
- Fixed a bug that made all requests be made twice, that causing increase wait time from responses and consume unnecessary tokens.
- Fixed a bug related to the `Base API URL` option, which could not take effect if changed.
- Improved the `Add Summary For Entire Class` command to avoid bad formatting.

### 2.7.2

- Added the new Model option GPT-4o.
- Now the GPT-4-Turbo model points to the default version (the latest available). Before, it was using the preview version.

### 2.7.1

- Added the new `Custom Model` option.

### 2.7.0

- Added the new `Code Review` functionality.

### 2.6.0

- Added the new `Generate Git Changes Comment` Command on the Visual chatGPT Studio Tool Window.
- Improvements for the Add Summary, Add Tests, Complete and Optimize commands result. In most cases will only write the code from OpenAI responses, ignoring any additional comments that could come with the OpenAI response. To make this possible, unfortunately I had to disable the ability to write responses via stream for these commands, so now they will work as "Single Response" regardless of the option selected via Options.
- Other minor improvements.

### 2.5.2

- Added logging writing in case of exceptions in the Visual Studio Output window.
- Small adjustment to the spacing of chat items.
- A fix was made to the requests made to the APIs, where the content was not in accordance with the OpenAI standard. This could cause errors.

### 2.5.1

- Change so that the GPT_4_Turbo model always automatically points to the latest version made available by OpenAI. Currently, the latest version is gpt-4-0125-preview (see more details [here](https://openai.com/blog/new-embedding-models-and-api-updates)).
- Update the Cancel command icon.

### 2.5.0

- Update appearance and user interface.
- Small improvement in the automatic creation of titles for chats.

### 2.4.5

- Fixed the compatibility with the Visual Studio ARM edition.
- Small improvement in the automatic creation of titles for chats.

### 2.4.4

- Small improvements in adding comment characters to some commands that write comments in the code editor.
- Small improvement in the automatic creation of titles for chats.

### 2.4.3

- Added the gpt-4-32k model.
- Removed the gpt-3.5-turbo-16k model. OpenAI currently points to gpt-3.5-turbo model.
- Fixed a bug that was causing duplicate requests to the API.
- Improved verification of changes to connection-related options to apply them in execution mode, avoiding the need to restart Visual Studio to take effect.

### 2.4.2

- Added the Word Wrap switch button on Tool Window.
- Added the feature to automatically remove early chat messages from conversation history when the context limit has reached.

### 2.4.1

- Fixed a bug introduced in the last release when trying to use the Turbo Chat Window. The bug is related to the creation of the file to store the chat history.

### 2.4.0

- Added tabs to the Turbo Chat.
- Added Chats history.
- Fixed a behavior that cause the opening of all the extension Tool Windows when opened one of them.

### 2.3.0

- Added the new models gpt-3.5-turbo-1106 and gpt-4-1106-preview (maybe not work with Azure yet). See [here](https://openai.com/blog/new-models-and-developer-products-announced-at-devday) for more details about these new models.
- Added the new options "Log Request" and "Log Responses". If ON, all requests and/or responses to OpenAI will be logged to the Output window.
- Commands Options reformulated. Now it's possible set commands by Projects and Solutions.
- Added the new "Visual chatGPT Studio Solution Context" window, where it is possible to add items from projects to the context of requests to OpenAI.
- Fixed a bug that was preventing an error message from being displayed in some cases if communication with OpenAI failed. As a result, the execution of the request was not interrupted.

### 2.2.2

- Added the possibility to hold the SHIFT key when executing the "Send Code" command to write the code in the Turbo Chat Window instead of the code editor.
- Turbo Chat Code Command on options changed from "Apply the change requested by the user to the code" to "Apply the change requested by the user to the code, but rewrite the original code that was not changed" for better behavior.

### 2.2.1

- Added timeout to requests.

### 2.2.0

- Added the "Send Code" command on Turbo Chat window.

### 2.1.0

- Added the "Cancel" commands to stop receiving/waiting the requests.

### 2.0.0

- Completion models removed. Now all requests will be made through Chat Models.
- Adjusted the parameters of the Options for Azure due to no longer needing two resources.
- Some minor refactors and fixes.

### 1.13.0

- Added the new Option "Minify Requests". If true, all requests to OpenAI will be minified. Ideal to save Tokens.
- Added the new Option "Characters To Remove From Requests". Add characters or words to be removed from all requests made to OpenAI. They must be separated by commas, e.g. "a,1,TODO:,{".
- Now the progress status will show on the Tool Windows itself.
- Fix for "Add Summary For Entire Class" command when the class has "region" tags.
- Fix the "Add Comments" command to detect properly if was selected one or more lines code.

### 1.12.1

- Minor fixes to the "Add Summary For Entire Class" command.
- When displaying the Diff View for the command "Optimize (Diff View)", the file extension on Diff View will be according to the original file extension.

### 1.12.0

- Added the new command "Optimize (Diff View)".
- Minor fix to the "Add Summary For Entire Class" command where in some cases where chatGPT did not respond well, the class code was erased.
- Added Chinese readme. Thanks to [ATFmxyl](https://github.com/ATFmxyl) for the collaboration!

### 1.11.2

- Update to add summaries for constructors members when the command "Add Summary For Entire Class" is executed.

### 1.11.1

- Update to add summaries for more class members when the command "Add Summary For Entire Class" is executed.

### 1.11.0

- Added the new command "Add Summary For Entire Class".
- Added the gpt-3.5-turbo-16k model for the Turbo Chat Window.
- Added the "Base API" option.

### 1.10.0

- Added the new command "Translate".
- Grouped options for better usability.
- Added feedback when code was copied on Tool Window.

### 1.9.3

- Added option that permit to define the specific Azure Deployment ID for the Turbo Chat window.
- Added option that permit to define the Azure API version for the Turbo Chat window.

### 1.9.2

- Removed the "one method selection" limit.

### 1.9.1

- Changed extension icon for VS 2019 edition.

### 1.9.0

- Added Visual Studio 2019 compatibility. Thanks to [przemsiedl](https://github.com/przemsiedl).
- Fixed proxy connection (experimental). Thanks to [52017126](https://github.com/52017126).
- Added possibility to connect through Azure (experimental). Thanks to [Rabosa616](https://github.com/Rabosa616).
- The CodeDavinci and CodeCushman models have been removed as they have been deprecated by OpenAI. Thanks to [ekomsctr](https://github.com/ekomsctr) for the feedback about this.
- Fixed comment chars for the commands "Explain" and "Find Bugs" when the language is not C#.
- Added option to define the OpenAI Organization.
- Added the GTP-4 model language for the TurboChat Window (experimental).
- Added feedback when code was copied on TurboChat Window.

### 1.8.0

- Added proxy connection (experimental). Thanks to [SundayCoding](https://github.com/SundayCoding).

### 1.7.5

- Improvements on "Add Summary" command.

### 1.7.4

- Some improvements on turbo chat window.
- Added the new option parameter "Single Response". If true, the entire response will be displayed at once on code editor. Less undo history but longer waiting time.

### 1.7.3

- Improvements on turbo chat window. Added syntax highlight, vertical scroll and copy button.
- Improved TSQL syntax detection.
- Now when a context menu command is executed holding the SHIFT key, the request made is also written in the request box.

### 1.7.2

- Fixed a bug when the selected code has some special characters like '<' and '>'.

### 1.7.1

- Added icons to the context menu items.
- Improved Api Token validation. Now it's not necessary restart the Visual Studio after set the token at first time, and avoided a bug related.

### 1.7.0

- Added the new "Visual chatGPT Studio Turbo" tool window.
- Sometimes when performing the "Add Summary" command, the API ends up adding the characters "{" and/or "}" to its response. Therefore I am removing these characters from the response when they are returned as a result of this command.
- Added the new custom commands Before, After and Replace.
- Added the "Stop Sequences" on options (Credits to [graham83](https://github.com/graham83)).

### 1.6.1

- Fixed a bug introduced on previous release for the "Explain, "Add Comments" and "Add Summary" commands.

### 1.6.0

- Removed mention to Visual Studio 2019 due incompatibility.
- Added comment prefix for "Explain" and "Find Bugs" commands.
- Added line break after 160 characters on the same line for "Explain" and "Find Bugs" commands.
- Do nothing when API send only break lines on response begin (avoid new brank lines).
- Commands moved to a submenu.
- Added shortcuts to the commands.
- Fixed error when executing commands with SHIFT key in some scenarios.

### 1.5.1

- Redirect the commands responses to the tool window. To do, press and hold the SHIFT key and select the command. The response will be written on tool window instead on the code editor.

### 1.5.0

- Added syntax highlight to text editor on tool window
- Now text editor show the lines number.

### 1.4.0

- Added the possibility to customize the commands through the options.
- Added the possibility to resize the text editor on tool window.
- Added a shortcut to "Request" button on tool window. Now you can send the request just pressing CTRL+Enter.

### 1.3.2

- Now the extension will show the OpenAI API error detail when it occurs. In this way you can know what is really happening:

![image](https://user-images.githubusercontent.com/63928228/223844744-e7a9b350-b590-40c6-a36a-6ce8d327eb9f.png)

### 1.3.1

- Added support for Visual Studio ARM architecture.

### 1.3.0

- Improved the "Add Comments" command.

- Now it's possible to customize the OpenAI API requests parameters:

<img src="https://user-images.githubusercontent.com/63928228/223844877-d11a524b-472d-4046-94c5-70e6d3a49752.png" width="70%">

But only change the default values if you know what you're doing, otherwise you might experience some unexpected behavior.

For more details about each property, see the OpenAI documentation: [https://platform.openai.com/docs/api-reference/completions/create](https://platform.openai.com/docs/api-reference/completions/create).

You can play with these parameters [here](https://platform.openai.com/playground) before changing them in the plugin.

### 1.2.3

- Fixed commands when select code from bottom to top or end to start (Thanks to Tim Yen to alert me about this issue).
- More improvements on "Summary" command.
- Minor bugs fixes.

### 1.2.2

- Improved the "Summary" command.

### 1.2.1

- Improved the "Summary" command. Now most of times the chatGPT will not write again the method/property head.
- Added a validation to avoid the chatGPT response be write on wrong line.
- Other minor fixes.

### 1.2.0

- Added the new command "Complete". Start write a method, select it and ask for complete.
- Now the extension is compatible with Visual Studio 2019.
- Minor bugs fixes.

### 1.1.0

- I figure out a way to improve the size of the requests. This will resolve the most of "Some error occur. Please try again or change the selection." error. Now in most cases instead of failing, if the data limit is exceeded chatGPT will not write the entire response.

### 1.0.1 

- Fixed a bug that prevented the window tool from working after closing and reopening Visual Studio .
- Added a feedback when the extension is waiting for chatGPT response:

![image](https://user-images.githubusercontent.com/63928228/223844933-2e6775d6-c657-42a1-9417-111aa3fb3245.png)