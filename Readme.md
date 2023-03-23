# Multi-Language Central Logging with Graylog

Multi-Language central logging with Graylog

## Run Project

1. Run docker compose:
```sh
docker-compose up -d
```

2. Open [Graylog on browser](http://localhost:9000) (admin:admin) and Create 'Gelf TCP' Input. Input properties must look like below:
```sh
bind_address: 0.0.0.0
decompress_size_limit: 8388608
max_message_size: 2097152
number_worker_threads: 4
override_source: <empty>
port: 12201
recv_buffer_size: 1048576
tcp_keepalive: false
tls_cert_file: <empty>
tls_client_auth: disabled
tls_client_auth_cert_file: <empty>
tls_enable: false
tls_key_file: <empty>
tls_key_password: ********
use_null_delimiter: true
```

3. Run Applications

Dotnet Console:
```sh
cd apps/dotnet-console
dotnet run
```