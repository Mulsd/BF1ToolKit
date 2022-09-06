using BF1ToolKit.API.Requ;
using BF1ToolKit.API.Resp;

using RestSharp;

namespace BF1ToolKit.API;

public static class BF1API
{
    private const string Host = "https://sparta-gw.battlelog.com/jsonrpc/pc/api";

    private static RestClient client;
    private static Dictionary<string, string> headers;

    public static string SessionId = string.Empty;

    /// <summary>
    /// 初始化RestSharp，并返回是否初始化成功
    /// </summary>
    /// <returns></returns>
    public static bool Init()
    {
        try
        {
            if (client == null)
            {
                var options = new RestClientOptions(Host)
                {
                    MaxTimeout = 5000,
                    ThrowOnAnyError = true
                };

                client = new RestClient(options);
                headers = new Dictionary<string, string>
                {
                    ["User-Agent"] = "ProtoHttp 1.3/DS 15.1.2.1.0 (Windows)",
                    ["X-GatewaySession"] = SessionId,
                    ["X-ClientVersion"] = "release-bf1-lsu35_26385_ad7bf56a_tunguska_all_prod",
                    ["X-DbId"] = "Tunguska.Shipping2PC.Win32",
                    ["X-CodeCL"] = "3779779",
                    ["X-DataCL"] = "3779779",
                    ["X-SaveGameVersion"] = "26",
                    ["X-HostingGameId"] = "tunguska",
                    ["X-Sparta-Info"] = "tenancyRootEnv=unknown; tenancyBlazeEnv=unknown"
                };
            }

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    /// <summary>
    /// 根据AuthCode获取玩家SessionId
    /// </summary>
    /// <param name="authCode">通过本地重定向获取</param>
    /// <returns></returns>
    public static async Task<RespContent> GetEnvIdViaAuthCode(string authCode)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "Authentication.getEnvIdViaAuthCode",
                @params = new
                {
                    authCode,
                    locale = "zh-tw"
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 设置战地1 API语言为 繁体中文
    /// </summary>
    /// <returns></returns>
    public static async Task<RespContent> SetAPILocale()
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "CompanionSettings.setLocale",
                @params = new
                {
                    locale = "zh_TW"
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 获取战地1欢迎语
    /// </summary>
    /// <returns></returns>
    public static async Task<RespContent> GetWelcomeMessage()
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "Onboarding.welcomeMessage",
                @params = new
                {
                    game = "tunguska",
                    minutesToUTC = "-480"
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 踢出目标玩家
    /// </summary>
    /// <param name="gameId">目标服务器GameId</param>
    /// <param name="personaId">目标玩家数字Id</param>
    /// <param name="reason">踢出理由</param>
    /// <returns></returns>
    public static async Task<RespContent> RSPKickPlayer(long gameId, long personaId, string reason)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "RSP.kickPlayer",
                @params = new
                {
                    game = "tunguska",
                    gameId,
                    personaId,
                    reason
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 更换玩家到指定队伍
    /// </summary>
    /// <param name="gameId">目标服务器GameId</param>
    /// <param name="personaId">目标玩家数字Id</param>
    /// <param name="teamId">目标队伍Id</param>
    /// <returns></returns>
    public static async Task<RespContent> RSPMovePlayer(long gameId, long personaId, int teamId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "RSP.movePlayer",
                @params = new
                {
                    game = "tunguska",
                    personaId,
                    gameId,
                    teamId,
                    forceKill = true,
                    moveParty = false
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 更换服务器地图
    /// </summary>
    /// <param name="persistedGameId">服务器GUID</param>
    /// <param name="levelIndex">目标地图索引</param>
    /// <returns></returns>
    public static async Task<RespContent> RSPChooseLevel(string persistedGameId, int levelIndex)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "RSP.chooseLevel",
                @params = new
                {
                    game = "tunguska",
                    persistedGameId,
                    levelIndex
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 添加服务器管理员
    /// </summary>
    /// <param name="serverId">服务器Id</param>
    /// <param name="personaName">管理员名称</param>
    /// <returns></returns>
    public static async Task<RespContent> AddServerAdmin(string serverId, string personaName)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "RSP.addServerAdmin",
                @params = new
                {
                    game = "tunguska",
                    serverId,
                    personaName
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 移除服务器管理员
    /// </summary>
    /// <param name="serverId">服务器Id</param>
    /// <param name="personaId">管理员数字Id</param>
    /// <returns></returns>
    public static async Task<RespContent> RemoveServerAdmin(string serverId, string personaId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "RSP.removeServerAdmin",
                @params = new
                {
                    game = "tunguska",
                    serverId,
                    personaId
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 添加服务器VIP
    /// </summary>
    /// <param name="serverId">服务器Id</param>
    /// <param name="personaName">VIP玩家名称</param>
    /// <returns></returns>
    public static async Task<RespContent> AddServerVip(string serverId, string personaName)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "RSP.addServerVip",
                @params = new
                {
                    game = "tunguska",
                    serverId,
                    personaName
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 移除服务器VIP
    /// </summary>
    /// <param name="serverId">服务器Id</param>
    /// <param name="personaId">VIP玩家数字Id</param>
    /// <returns></returns>
    public static async Task<RespContent> RemoveServerVip(string serverId, string personaId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "RSP.removeServerVip",
                @params = new
                {
                    game = "tunguska",
                    serverId,
                    personaId
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 添加服务器BAN
    /// </summary>
    /// <param name="serverId">服务器Id</param>
    /// <param name="personaName">BAN玩家名称</param>
    /// <returns></returns>
    public static async Task<RespContent> AddServerBan(string serverId, string personaName)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "RSP.addServerBan",
                @params = new
                {
                    game = "tunguska",
                    serverId,
                    personaName
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 移除服务器BAN
    /// </summary>
    /// <param name="serverId">服务器Id</param>
    /// <param name="personaId">BAN玩家数字Id</param>
    /// <returns></returns>
    public static async Task<RespContent> RemoveServerBan(string serverId, string personaId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "RSP.removeServerBan",
                @params = new
                {
                    game = "tunguska",
                    serverId,
                    personaId
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 获取服务器完整详情信息
    /// </summary>
    /// <param name="gameId">服务器GameId</param>
    /// <returns></returns>
    public static async Task<RespContent> GetFullServerDetails(long gameId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "GameServer.getFullServerDetails",
                @params = new
                {
                    game = "tunguska",
                    gameId
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 获取服务器RSP详情信息
    /// </summary>
    /// <param name="serverId">服务器Id</param>
    /// <returns></returns>
    public static async Task<RespContent> GetServerDetails(string serverId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "RSP.getServerDetails",
                @params = new
                {
                    game = "tunguska",
                    serverId
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 更新服务器信息
    /// </summary>
    /// <param name="reqBody">服务器请求Json</param>
    /// <returns></returns>
    public static async Task<RespContent> UpdateServer(UpdateServer reqBody)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 搜索服务器
    /// </summary>
    /// <param name="serverName">服务器名称关键字</param>
    /// <returns></returns>
    public static async Task<RespContent> SearchServers(string serverName)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "GameServer.searchServers",
                @params = new
                {
                    filterJson = "{\"version\":6,\"name\":\"" + serverName + "\"}",
                    game = "tunguska",
                    limit = 20,
                    protocolVersion = "3779779"
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 离开服务器
    /// </summary>
    /// <param name="gameId">服务器GameId</param>
    /// <returns></returns>
    public static async Task<RespContent> LeaveGame(long gameId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "Game.leaveGame",
                @params = new
                {
                    game = "tunguska",
                    gameId
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 通过玩家数字Id获取玩家相关信息
    /// </summary>
    /// <param name="personaId">玩家数字Id</param>
    /// <returns></returns>
    public static async Task<RespContent> GetPersonasByIds(long personaId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "RSP.getPersonasByIds",
                @params = new
                {
                    game = "tunguska",
                    personaIds = new[] { personaId }
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 获取玩家基础数据
    /// </summary>
    /// <param name="personaId">玩家数字Id</param>
    /// <returns></returns>
    public static async Task<RespContent> DetailedStatsByPersonaId(long personaId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "Stats.detailedStatsByPersonaId",
                @params = new
                {
                    game = "tunguska",
                    personaId
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 获取玩家武器数据
    /// </summary>
    /// <param name="personaId">玩家数字Id</param>
    /// <returns></returns>
    public static async Task<RespContent> GetWeaponsByPersonaId(long personaId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "Progression.getWeaponsByPersonaId",
                @params = new
                {
                    game = "tunguska",
                    personaId
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 获取玩家载具数据
    /// </summary>
    /// <param name="personaId">玩家数字Id</param>
    /// <returns></returns>
    public static async Task<RespContent> GetVehiclesByPersonaId(long personaId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "Progression.getVehiclesByPersonaId",
                @params = new
                {
                    game = "tunguska",
                    personaId
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 获取玩家正在游玩服务器
    /// </summary>
    /// <param name="personaId">玩家数字Id</param>
    /// <returns></returns>
    public static async Task<RespContent> GetServersByPersonaIds(long personaId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "GameServer.getServersByPersonaIds",
                @params = new
                {
                    game = "tunguska",
                    personaIds = new[] { personaId }
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }

    /// <summary>
    /// 获取玩家佩戴的图章
    /// </summary>
    /// <param name="personaId">玩家数字Id</param>
    /// <returns></returns>
    public static async Task<RespContent> GetEquippedEmblem(long personaId)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respContent = new RespContent();

        try
        {
            headers["X-GatewaySession"] = SessionId;
            respContent.IsSuccess = false;

            var reqBody = new
            {
                jsonrpc = "2.0",
                method = "Emblems.getEquippedEmblem",
                @params = new
                {
                    platform = "pc",
                    personaId
                },
                id = Guid.NewGuid()
            };

            var request = new RestRequest()
                .AddHeaders(headers)
                .AddJsonBody(reqBody);

            var response = await client.ExecutePostAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                respContent.IsSuccess = true;
                respContent.Message = response.Content;
            }
            else
            {
                var respError = JsonUtil.JsonDese<RespError>(response.Content);
                respContent.Message = $"{respError.error.code} {respError.error.message}";
            }
        }
        catch (Exception ex)
        {
            respContent.Message = ex.Message;
        }

        sw.Stop();
        respContent.ExecTime = sw.Elapsed.TotalSeconds;

        return respContent;
    }
}