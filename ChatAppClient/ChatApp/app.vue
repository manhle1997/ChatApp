<template>
  <div>Chat to stranger</div>
  <div><button>SignUp</button></div>
  <div>
    <input type="text" maxlength="20" placeholder="Set your nickname"/>
    <button>Start</button>
  </div>
  <div class="chat_area">
    <div v-for="item in  mess" :key="item">{{ item }}</div>
  </div>
  <div class="send_message">
    <input type="text">
    <button>Send</button>
  </div>
</template>
<script>

export default {
  data() {
    return {
      mess: [],
    };
  },
  methods:{
    
  }
};
</script>
<style>
.chat_area{
  width: 500px;
  height: 500px;
  border: 1px solid ;
  margin-top: 5px;
  overflow-y: scroll;
}
.send_message{
  margin-top: 15px;
}
</style>
