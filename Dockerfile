FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

COPY myapp/ ./myapp/
COPY entrypoint.sh /entrypoint.sh

RUN chmod +x /entrypoint.sh

ENTRYPOINT ["/entrypoint.sh"]