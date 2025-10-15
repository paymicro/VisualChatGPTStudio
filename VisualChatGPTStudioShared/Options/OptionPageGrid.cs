using JeffPires.VisualChatGPTStudio.Utils;
using Microsoft.VisualStudio.Shell;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace JeffPires.VisualChatGPTStudio.Options
{
    /// <summary>
    /// Represents a class that provides a dialog page for displaying general options.
    /// </summary>
    [ComVisible(true)]
    public class OptionPageGridGeneral : DialogPage
    {
        #region General

        [Category("General")]
        [DisplayName("API Key")]
        [Description("Set API Key. For OpenAI API, see \"https://beta.openai.com/account/api-keys\" for more details.")]
        public string ApiKey { get; set; }

        [Category("General")]
        [DisplayName("OpenAI Service")]
        [Description("Select how to connect: OpenAI API or Azure OpenAI.")]
        [DefaultValue(OpenAIService.OpenAI)]
        [TypeConverter(typeof(EnumConverter))]
        public OpenAIService Service { get; set; }

        [Category("General")]
        [DisplayName("Single Response")]
        [Description("If true, the entire response will be displayed at once (less undo history but longer waiting time). The commands Add Summary, Add Tests, Complete and Optimize will only works as \"Single Response\".")]
        [DefaultValue(false)]
        public bool SingleResponse { get; set; } = false;

        [Category("General")]
        [DisplayName("Proxy")]
        [Description("Connect to OpenAI through a proxy.")]
        [DefaultValue("")]
        public string Proxy { get; set; } = string.Empty;

        [Category("General")]
        [DisplayName("Minify Requests")]
        [Description("If true, all requests to OpenAI will be minified. Ideal to save Tokens.")]
        [DefaultValue(false)]
        public bool MinifyRequests { get; set; } = false;

        [Category("General")]
        [DisplayName("Characters To Remove From Requests")]
        [Description("Add characters or words to be removed from all requests made to OpenAI. They must be separated by commas, e.g. a,1,TODO:,{")]
        [DefaultValue("")]
        public string CharactersToRemoveFromRequests { get; set; } = string.Empty;

        [Category("General")]
        [DisplayName("Log Requests")]
        [Description("If true, all requests to OpenAI will be logged to the Output window.")]
        [DefaultValue(false)]
        public bool LogRequests { get; set; } = false;

        [Category("General")]
        [DisplayName("Log Responses")]
        [Description("If true, all responses to OpenAI will be logged to the Output window.")]
        [DefaultValue(false)]
        public bool LogResponses { get; set; } = false;

        [Category("General")]
        [DisplayName("Log SQL Server Agent Queries")]
        [Description("If true, all queries executed by the SQL Server Agent will be logged to the Output window.")]
        [DefaultValue(false)]
        public bool LogSqlServerAgentQueries { get; set; } = false;

        [Category("General")]
        [DisplayName("Log API Agent Request and Responses")]
        [Description("If true, all requests and responses made by the API Agent will be logged to the Output window.")]
        [DefaultValue(false)]
        public bool LogAPIAgentRequestAndResponses { get; set; } = false;

        [Category("General")]
        [DisplayName("Use Enter to send request in chat")]
        [Description("If true, command uses Enter to send command instead Ctrl+Enter.")]
        [DefaultValue(false)]
        public bool UseEnter { get; set; } = false;
        #endregion General

        #region Model Parameters

        [Category("Model Parameters")]
        [DisplayName("Max Tokens")]
        [Description("See \"https://help.openai.com/en/articles/4936856-what-are-tokens-and-how-to-count-them\" for more details.")]
        public int? MaxTokens { get; set; }

        [Category("Model Parameters")]
        [DisplayName("Temperature")]
        [Description("What sampling temperature to use. Higher values means the model will take more risks. Try 0.9 for more creative applications, and 0 for ones with a well-defined answer.")]
        public double? Temperature { get; set; }

        [Category("Model Parameters")]
        [DisplayName("Presence Penalty")]
        [Description("The scale of the penalty applied if a token is already present at all. Should generally be between 0 and 1, although negative numbers are allowed to encourage token reuse.")]
        public double? PresencePenalty { get; set; }

        [Category("Model Parameters")]
        [DisplayName("Frequency Penalty")]
        [Description("The scale of the penalty for how often a token is used. Should generally be between 0 and 1, although negative numbers are allowed to encourage token reuse.")]
        public double? FrequencyPenalty { get; set; }

        [Category("Model Parameters")]
        [DisplayName("top p")]
        [Description("An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.")]
        public double? TopP { get; set; }

        [Category("Model Parameters")]
        [DisplayName("Stop Sequences")]
        [Description("Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence. Separate different stop strings by a comma e.g. '},;,stop'")]
        [DefaultValue("")]
        public string StopSequences { get; set; } = string.Empty;

        #endregion Model Parameters

        #region Completion Parameters

        [Category("Completion Parameters")]
        [DisplayName("Completion Base API URL Override")]
        [Description("Change the Completion API connection URL if you wish to do so for some reason, for example use a custom LLM deployment specific only for the Completions. Example: https://myurl.openai.com")]
        [DefaultValue("")]
        public string CompletionBaseAPI { get; set; } = string.Empty;

        [Category("Completion Parameters")]
        [DisplayName("Completion Model Language Override")]
        [Description("Specify a custom model name for Completion requests. Overrides 'OpenAI. Model Language' if not empty.")]
        [DefaultValue("")]
        public string CompletionCustomModel { get; set; } = "";

        [Category("Completion Parameters")]
        [DisplayName("Max Tokens")]
        [Description("See \"https://help.openai.com/en/articles/4936856-what-are-tokens-and-how-to-count-them\" for more details.  Overrides 'Model Parameters. Max Tokens' if not empty.")]
        public int? CompletionMaxTokens { get; set; }

        [Category("Completion Parameters")]
        [DisplayName("Temperature")]
        [Description("What sampling temperature to use. Higher values means the model will take more risks. Try 0.9 for more creative applications, and 0 for ones with a well-defined answer. Overrides 'Model Parameters. Temperature' if not empty.")]
        public double? CompletionTemperature { get; set; }

        [Category("Completion Parameters")]
        [DisplayName("Presence Penalty")]
        [Description("The scale of the penalty applied if a token is already present at all. Should generally be between 0 and 1, although negative numbers are allowed to encourage token reuse. Overrides 'Model Parameters. Presence Penalty' if not empty.")]
        public double? CompletionPresencePenalty { get; set; }

        [Category("Completion Parameters")]
        [DisplayName("Frequency Penalty")]
        [Description("The scale of the penalty for how often a token is used. Should generally be between 0 and 1, although negative numbers are allowed to encourage token reuse. Overrides 'Model Parameters. Frequency Penalty' if not empty.")]
        public double? CompletionFrequencyPenalty { get; set; }

        [Category("Completion Parameters")]
        [DisplayName("top p")]
        [Description("An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered. Overrides 'Model Parameters. top p' if not empty.")]
        public double? CompletionTopP { get; set; }

        #endregion Completion Parameters

        #region Azure

        [Category("Azure")]
        [DisplayName("Resource Name")]
        [Description("The Azure OpenAI resource name.")]
        [DefaultValue("")]
        public string AzureResourceName { get; set; } = string.Empty;

        [Category("Azure")]
        [DisplayName("Deployment Name")]
        [Description("Set Azure OpenAI deployment name.")]
        [DefaultValue("")]
        public string AzureDeploymentId { get; set; } = string.Empty;

        [Category("Azure")]
        [DisplayName("API Version")]
        [Description("Set the Azure OpenAI API version. You can check the available versions here: https://learn.microsoft.com/en-us/azure/ai-services/openai/reference#completions")]
        [DefaultValue("2024-12-01-preview")]
        public string AzureApiVersion { get; set; } = "2024-12-01-preview";

        [Category("Azure")]
        [DisplayName("Azure URL Override")]
        [Description("Manually define the Azure OpenAI connection URL instead of using 'Resource Name', 'Deployment Name', and 'API Version'. This is useful for custom endpoints. When this parameter is set, the other parameters will be ignored.")]
        [DefaultValue("")]
        public string AzureUrlOverride { get; set; } = "";

        [Category("Azure")]
        [DisplayName("API Version For Computer Use")]
        [Description("Set the Azure OpenAI API version for computer-use model.")]
        [DefaultValue("preview")]
        public string AzureApiVersionForComputerUse { get; set; } = "preview";

        [Category("Azure")]
        [DisplayName("Azure URL Override For Computer Use")]
        [Description("Manually define the Azure OpenAI connection URL instead of using 'Resource Name', 'Deployment Name', and 'API Version' for computer-use model. This is useful for custom endpoints. When this parameter is set, the other parameters will be ignored.")]
        [DefaultValue("")]
        public string AzureUrlOverrideForComputerUse { get; set; } = "";

        #endregion Azure

        #region Azure Entra ID

        [Category("Azure Entra ID")]
        [DisplayName("Entra ID Authentication")]
        [Description("Only available for Azure Open AI Service. If true, use your Microsoft Account to authenticate to the Azure Open AI Service.")]
        [DefaultValue(false)]
        public bool AzureEntraIdAuthentication { get; set; } = false;

        [Category("Azure Entra ID")]
        [DisplayName("Application Id")]
        [Description("If you choose to authenticate with Entra ID, you need to provide the OpenAI Application (Client) ID registered in Entra ID.")]
        [DefaultValue("")]
        public string AzureEntraIdApplicationId { get; set; } = string.Empty;

        [Category("Azure Entra ID")]
        [DisplayName("Tenant Id")]
        [Description("If you choose to authenticate with Entra ID, you need to provide the Tenant ID.")]
        [DefaultValue("")]
        public string AzureEntraIdTenantId { get; set; } = string.Empty;

        #endregion Azure Entra ID

        #region OpenAI

        [Category("OpenAI")]
        [DisplayName("Organization")]
        [Description("Set the OpenAI Organization. (Optional)")]
        public string OpenAIOrganization { get; set; }

        [Category("OpenAI")]
        [DisplayName("Base API URL")]
        [Description("Change the API connection URL if you wish to do so for some reason, for example use a custom LLM deployment. Example: https://myurl.openai.com")]
        [DefaultValue("")]
        public string BaseAPI { get; set; } = string.Empty;

        [Category("OpenAI")]
        [DisplayName("Model Language")]
        [Description("See \"https://platform.openai.com/docs/models\" for more details.")]
        [DefaultValue("gpt-4.1-mini")]
        public string Model { get; set; } = "gpt-4.1-mini";

        [Category("OpenAI")]
        [DisplayName("API Version Override")]
        [Description("Change the API version to use custom endpoint")]
        [DefaultValue("")]
        public string ApiVersion { get; set; } = string.Empty;

        [Category("OpenAI")]
        [DisplayName("Stream")]
        [Description("Change the Stream option if you wish to stream response")]
        [DefaultValue(false)]
        public bool CompletionStream { get; set; } = false;

        #endregion OpenAI

        #region Turbo Chat

        [Category("Turbo Chat")]
        [DisplayName("Turbo Chat Behavior")]
        [Description("Set the behavior of the assistant. (API System Message)")]
        [DefaultValue("You are a programmer assistant called Visual chatGPT Studio, and your role is help developers and resolve programmer problems.")]
        public string TurboChatBehavior { get; set; } = "You are a programmer assistant called Visual chatGPT Studio, and your role is help developers and resolve programmer problems.";

        [Category("Turbo Chat")]
        [DisplayName("Turbo Chat Code Command")]
        [Description("Define the instruction that will send to the assistant when requesting code assistance.")]
        [DefaultValue("Apply the change requested by the user to the code, but rewrite the original code that was not changed")]
        public string TurboChatCodeCommand { get; set; } = "Apply the change requested by the user to the code, but rewrite the original code that was not changed";
        #endregion Turbo Chat

        #region Copilot

#if COPILOT_ENABLED

        [Category("Copilot")]
        [DisplayName("Copilot Enabled")]
        [Description("If true, the Copilot functionality will be enabled.")]
        [DefaultValue(true)]
        public bool CopilotEnabled { get; set; } = true;

        [Category("Copilot")]
        [DisplayName("Copilot Command")]
        [Description("Command to request to OpenAI generates suggestions to apply to the code.")]
        [DefaultValue("Please complete.")]
        public string CopilotCommand { get; set; } = "Please complete.";

#endif

        #endregion Copilot

        #region Commands

        [Category("Commands")]
        [DisplayName("Generate Git Changes Comment Command")]
        [Description("Command to request to AI generates a comment based on current repository git changes.")]
        [DefaultValue("Based on the changes, write a concise comment for I can use in readme file and/or git changes push comment. Write each change in a new line. Use Markdown format.")]
        public string GenerateGitCommentCommand { get; set; } = "Based on the changes, write a concise comment for I can use in readme file and/or git changes push comment. Write each change in a new line. Use Markdown format.";

        [Category("Commands")]
        [DisplayName("Code Review Command")]
        [Description("Command to request to AI generates a Code Review on current repository git changes.")]
        [DefaultValue("Make a code view of the following changes and indicate if there is anything that can or should be modified taking into account the following points: performance, readable and well-structured code, use of known patterns, security, potential bugs that must be eliminated, etc. If there is no recommendation for a point, ignore it, otherwise, say what is wrong and provide suggestions, including code examples. Be very concise and direct in your response, provide the code review in a very summarized manner.")]
        public string CodeReviewCommand { get; set; } = "Make a code view of the following changes and indicate if there is anything that can or should be modified taking into account the following points: performance, readable and well-structured code, use of known patterns, security, potential bugs that must be eliminated, etc. If there is no recommendation for a point, ignore it, otherwise, say what is wrong and provide suggestions, including code examples. Be very concise and direct in your response, provide the code review in a very summarized manner.";

        [Category("Commands")]
        [DisplayName("Tool Window System Message")]
        [Description("Set the System Message for requests made through the Tool Window (optional).")]
        [DefaultValue("")]
        public string ToolWindowSystemMessage { get; set; } = string.Empty;

        [Category("Commands")]
        [DisplayName("SQL Server Agent Command")]
        [Description("The command that guide the AI to create SQL Server scripts to be executed according the database template.")]
        [DefaultValue("Based on the database template provided following, generate SQL Server scripts that adhere to the structure of the template and execute then. The scripts should be created according to the specific instructions that may I will provide in requests, and you don't need show the data result in your responses.")]
        public string SqlServerAgentCommand { get; set; } = "Based on the database template provided following, generate SQL Server scripts that adhere to the structure of the template and execute then. The scripts should be created according to the specific instructions that may I will provide in requests, and you don't need show the data result in your responses.";

        [Category("Commands")]
        [DisplayName("API Agent Command")]
        [Description("The command that guide the AI to make calls to APIs.")]
        [DefaultValue("Based on the API's definition provided following, make API calls according to the instructions when requested. Do not include the base URL in the endpoints.")]
        public string APIAgentCommand { get; set; } = "Based on the API's definition provided following, make API calls according to the instructions when requested. Do not include the base URL in the endpoints.";

        [Category("Commands")]
        [DisplayName("Use Completion API for Commands")]
        [Description("If true, all requests to completion-code will use alternative 'Completion' model and API. Configure 'Completion Parameters' section before. Not works for Azure API.")]
        [DefaultValue(false)]
        public bool UseCompletion { get; set; } = false;
        #endregion Commands
    }
}
