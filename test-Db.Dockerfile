FROM mcr.microsoft.com/mssql/server:2017-latest-ubuntu

ENV MSSQL_SA_PASSWORD=Passw@rd
ENV ACCEPT_EULA=true
ENV MSSQL_PID=Express

RUN apt-get install mssql-tools
RUN ln -sfn /opt/mssql-tools/bin/sqlcmd /usr/bin/sqlcmd
RUN /opt/mssql/bin/sqlservr & sleep 20
