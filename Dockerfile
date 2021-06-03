FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

COPY . ./

ADD entrypoint.sh /entrypoint.sh
RUN chmod +x /entrypoint.sh

ENTRYPOINT ["/entrypoint.sh"]