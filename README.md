# Desenvolvimento de Aplicativos Móveis e Distribuídos
## Trabalho de Comunicação Indireta
### Overview do projeto

Este trabalho foi desenvolvido para a disciplina de Desenvolvimento de Aplicativos Móveis e Distribuídos do curso de Engenharia de Software da PUC Minas.

O objetivo do projeto é desenvolver um serviço de bate papo utilizando algum mecanismo de comunicação indireta. O MOM (_Message Oriented Middleware_) escolhido pelo nosso grupo foi o [_RabbitMQ_](https://www.rabbitmq.com)

O projeto consiste em um sistema _Web_ com duas funcionalidades básicas:

- O aluno deve ser capaz de cadastrar dúvidas e obter respostar.
- O monitor deve ser capaz de receber as dúvidas e cadastrar as respostas.

Os requisitos não funcionais do sistema são:

1. O sistema deve utilizar o RabbitMQ server com .NET Core.
2. O sistema deve utilizar o mecanismo de tópicos do RabbitMQ para rotear as mensagens de cada disciplina.
3. Os alunos enviam dúvidas para o monitor através da fila de mensagens da disciplina.
4. O monitor envia a resposta aos alunos interessados naquela disciplina usando uma arquitetura _publish subscribe_.
5. O servidor deverá ser disponibilizado em uma máquina diferente de _localhost_.

### Arquitetura do sistema
<br>

![Arquitetura](misc/DAMDArquitetura.png?raw=true "Title")

### Diagrama de classes
<br>

![Diagrama de Classes](misc/DAMDClasses.png?raw=true "Title")
