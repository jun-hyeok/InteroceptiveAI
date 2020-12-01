# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: mlagents_envs/communicator_objects/unity_rl_output.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
from google.protobuf import descriptor_pb2
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


from mlagents_envs.communicator_objects import agent_info_pb2 as mlagents__envs_dot_communicator__objects_dot_agent__info__pb2


DESCRIPTOR = _descriptor.FileDescriptor(
  name='mlagents_envs/communicator_objects/unity_rl_output.proto',
  package='communicator_objects',
  syntax='proto3',
  serialized_pb=_b('\n8mlagents_envs/communicator_objects/unity_rl_output.proto\x12\x14\x63ommunicator_objects\x1a\x33mlagents_envs/communicator_objects/agent_info.proto\"\xb9\x02\n\x12UnityRLOutputProto\x12L\n\nagentInfos\x18\x02 \x03(\x0b\x32\x38.communicator_objects.UnityRLOutputProto.AgentInfosEntry\x12\x14\n\x0cside_channel\x18\x03 \x01(\x0c\x1aI\n\x12ListAgentInfoProto\x12\x33\n\x05value\x18\x01 \x03(\x0b\x32$.communicator_objects.AgentInfoProto\x1an\n\x0f\x41gentInfosEntry\x12\x0b\n\x03key\x18\x01 \x01(\t\x12J\n\x05value\x18\x02 \x01(\x0b\x32;.communicator_objects.UnityRLOutputProto.ListAgentInfoProto:\x02\x38\x01J\x04\x08\x01\x10\x02\x42%\xaa\x02\"Unity.MLAgents.CommunicatorObjectsb\x06proto3')
  ,
  dependencies=[mlagents__envs_dot_communicator__objects_dot_agent__info__pb2.DESCRIPTOR,])




_UNITYRLOUTPUTPROTO_LISTAGENTINFOPROTO = _descriptor.Descriptor(
  name='ListAgentInfoProto',
  full_name='communicator_objects.UnityRLOutputProto.ListAgentInfoProto',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='value', full_name='communicator_objects.UnityRLOutputProto.ListAgentInfoProto.value', index=0,
      number=1, type=11, cpp_type=10, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=258,
  serialized_end=331,
)

_UNITYRLOUTPUTPROTO_AGENTINFOSENTRY = _descriptor.Descriptor(
  name='AgentInfosEntry',
  full_name='communicator_objects.UnityRLOutputProto.AgentInfosEntry',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='key', full_name='communicator_objects.UnityRLOutputProto.AgentInfosEntry.key', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='value', full_name='communicator_objects.UnityRLOutputProto.AgentInfosEntry.value', index=1,
      number=2, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=_descriptor._ParseOptions(descriptor_pb2.MessageOptions(), _b('8\001')),
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=333,
  serialized_end=443,
)

_UNITYRLOUTPUTPROTO = _descriptor.Descriptor(
  name='UnityRLOutputProto',
  full_name='communicator_objects.UnityRLOutputProto',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='agentInfos', full_name='communicator_objects.UnityRLOutputProto.agentInfos', index=0,
      number=2, type=11, cpp_type=10, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='side_channel', full_name='communicator_objects.UnityRLOutputProto.side_channel', index=1,
      number=3, type=12, cpp_type=9, label=1,
      has_default_value=False, default_value=_b(""),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[_UNITYRLOUTPUTPROTO_LISTAGENTINFOPROTO, _UNITYRLOUTPUTPROTO_AGENTINFOSENTRY, ],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=136,
  serialized_end=449,
)

_UNITYRLOUTPUTPROTO_LISTAGENTINFOPROTO.fields_by_name['value'].message_type = mlagents__envs_dot_communicator__objects_dot_agent__info__pb2._AGENTINFOPROTO
_UNITYRLOUTPUTPROTO_LISTAGENTINFOPROTO.containing_type = _UNITYRLOUTPUTPROTO
_UNITYRLOUTPUTPROTO_AGENTINFOSENTRY.fields_by_name['value'].message_type = _UNITYRLOUTPUTPROTO_LISTAGENTINFOPROTO
_UNITYRLOUTPUTPROTO_AGENTINFOSENTRY.containing_type = _UNITYRLOUTPUTPROTO
_UNITYRLOUTPUTPROTO.fields_by_name['agentInfos'].message_type = _UNITYRLOUTPUTPROTO_AGENTINFOSENTRY
DESCRIPTOR.message_types_by_name['UnityRLOutputProto'] = _UNITYRLOUTPUTPROTO
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

UnityRLOutputProto = _reflection.GeneratedProtocolMessageType('UnityRLOutputProto', (_message.Message,), dict(

  ListAgentInfoProto = _reflection.GeneratedProtocolMessageType('ListAgentInfoProto', (_message.Message,), dict(
    DESCRIPTOR = _UNITYRLOUTPUTPROTO_LISTAGENTINFOPROTO,
    __module__ = 'mlagents_envs.communicator_objects.unity_rl_output_pb2'
    # @@protoc_insertion_point(class_scope:communicator_objects.UnityRLOutputProto.ListAgentInfoProto)
    ))
  ,

  AgentInfosEntry = _reflection.GeneratedProtocolMessageType('AgentInfosEntry', (_message.Message,), dict(
    DESCRIPTOR = _UNITYRLOUTPUTPROTO_AGENTINFOSENTRY,
    __module__ = 'mlagents_envs.communicator_objects.unity_rl_output_pb2'
    # @@protoc_insertion_point(class_scope:communicator_objects.UnityRLOutputProto.AgentInfosEntry)
    ))
  ,
  DESCRIPTOR = _UNITYRLOUTPUTPROTO,
  __module__ = 'mlagents_envs.communicator_objects.unity_rl_output_pb2'
  # @@protoc_insertion_point(class_scope:communicator_objects.UnityRLOutputProto)
  ))
_sym_db.RegisterMessage(UnityRLOutputProto)
_sym_db.RegisterMessage(UnityRLOutputProto.ListAgentInfoProto)
_sym_db.RegisterMessage(UnityRLOutputProto.AgentInfosEntry)


DESCRIPTOR.has_options = True
DESCRIPTOR._options = _descriptor._ParseOptions(descriptor_pb2.FileOptions(), _b('\252\002\"Unity.MLAgents.CommunicatorObjects'))
_UNITYRLOUTPUTPROTO_AGENTINFOSENTRY.has_options = True
_UNITYRLOUTPUTPROTO_AGENTINFOSENTRY._options = _descriptor._ParseOptions(descriptor_pb2.MessageOptions(), _b('8\001'))
# @@protoc_insertion_point(module_scope)
