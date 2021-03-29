<template>
    <div>
        <Header /> 
        <div v-if="!isFinished">
            <Form 
                :isFinished="isFinished"
                @finished="isFinished = $event"
            /> 
        </div>
        <div v-if="isFinished">
            <Done />
        </div>
    </div>
</template>

<script>
import Header from './Header'
import Form from './Form'
import Done from './Done'

export default ({
    name:'Main',
    components: {
        Header,
        Form,
        Done
    },
    data() {
        return{
            isFinished:false
        }
    }
})
</script>
